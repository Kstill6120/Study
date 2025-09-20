window.addEventListener('DOMContentLoaded', function () {
    checkLoginStatus();
    updateCartCount();
    renderProducts();
    renderCart();
    showProductsByCategory('Tất cả sản phẩm');

    if (!localStorage.getItem('products')) {
        localStorage.setItem('products', JSON.stringify([]));
    }

    const products = JSON.parse(localStorage.getItem('products')) || [];
    const newestProducts = products.slice(0, 3);
    const productDisplay = document.getElementById('product-display');
    if (productDisplay) {
        productDisplay.innerHTML = '';
        newestProducts.forEach(p => {
            const div = document.createElement('div');
            div.className = 'product-card';
            const isSale = p.isSale === true || p.isSale === "true" || p.isSale === "1";
            const saleBadge = isSale ? '<span class="sale-badge">SALE</span>' : '';
            div.innerHTML = `
                <div class="product-image">
                    ${saleBadge}
                    <img src="${p.image}" alt="${p.name}" style="width: 100%; height: 100%; object-fit: cover;">
                </div>
                <div class="product-info">
                    <h3>${p.name}</h3>
                    <p>${parseFloat(p.price).toLocaleString()} VND</p>
                    <button class="add-to-cart-btn" data-id="${p.id}" data-name="${p.name}" data-price="${p.price}" data-image="${p.image}">
                        <i class="fas fa-shopping-cart"></i> Thêm vào giỏ
                    </button>
                </div>
            `;
            productDisplay.appendChild(div);
        });
    }
});

document.addEventListener('click', function (e) {
    // Thêm vào giỏ hàng
    if (e.target.classList.contains('add-to-cart-btn') || e.target.closest('.add-to-cart-btn')) {
        const button = e.target.closest('.add-to-cart-btn');
        const product = {
            id: button.dataset.id,
            name: button.dataset.name,
            price: parseFloat(button.dataset.price),
            image: button.dataset.image
        };
        addToCart(product);
    }

    // Tăng số lượng
    if (e.target.classList.contains('plus')) {
        const cart = JSON.parse(localStorage.getItem('cart')) || [];
        const index = e.target.dataset.index;
        cart[index].quantity += 1;
        localStorage.setItem('cart', JSON.stringify(cart));
        renderCart();
        updateCartCount();
    }

    // Giảm số lượng
    if (e.target.classList.contains('minus')) {
        const cart = JSON.parse(localStorage.getItem('cart')) || [];
        const index = e.target.dataset.index;
        if (cart[index].quantity > 1) {
            cart[index].quantity -= 1;
            localStorage.setItem('cart', JSON.stringify(cart));
            renderCart();
            updateCartCount();
        }
    }

    // Xoá sản phẩm
    if (e.target.closest('.remove-btn')) {
        const cart = JSON.parse(localStorage.getItem('cart')) || [];
        const index = e.target.closest('.remove-btn').dataset.index;
        cart.splice(index, 1);
        localStorage.setItem('cart', JSON.stringify(cart));
        renderCart();
        updateCartCount();
    }

    // Đăng xuất
    if (e.target.classList.contains('logout-btn')) {
        localStorage.removeItem('isLoggedIn');
        checkLoginStatus();
        alert('Bạn đã đăng xuất thành công!');
        window.location.href = 'index.html';
    }
});

function checkLoginStatus() {
    const isLoggedIn = localStorage.getItem('isLoggedIn') === 'true';
    const authLinks = document.querySelector('.auth-links');
    if (!authLinks) return;

    authLinks.innerHTML = isLoggedIn ? `
        <a href="account.html">Tài khoản</a>
        <a href="#" class="logout-btn">Đăng xuất</a>
    ` : `
        <a href="login.html">Đăng nhập</a>
        <a href="register.html">Đăng ký</a>
    `;
}

function showProductsByCategory(category) {
    const productDisplay = document.getElementById('product-display');
    const products = JSON.parse(localStorage.getItem('products')) || [];
    const filteredProducts = (category === 'Tất cả sản phẩm') ? products : products.filter(p => p.category === category);

    if (!productDisplay) return;
    productDisplay.innerHTML = '';

    filteredProducts.forEach(p => {
        const div = document.createElement('div');
        div.className = 'product-card';
        const isSale = p.isSale === true || p.isSale === "true" || p.isSale === "1";
        const saleBadge = isSale ? '<span class="sale-badge">SALE</span>' : '';
        div.innerHTML = `
            <div class="product-image">
                ${saleBadge}
                <img src="${p.image}" alt="${p.name}" style="width: 100%; height: 100%; object-fit: cover;">
            </div>
            <div class="product-info">
                <h3>${p.name}</h3>
                <p>${parseFloat(p.price).toLocaleString()} VND</p>
                <button class="add-to-cart-btn" data-id="${p.id}" data-name="${p.name}" data-price="${p.price}" data-image="${p.image}">
                    <i class="fas fa-shopping-cart"></i> Thêm vào giỏ
                </button>
            </div>
        `;
        productDisplay.appendChild(div);
    });
}

function renderProducts() {
    const products = JSON.parse(localStorage.getItem('products')) || [];
    const productDisplay = document.getElementById('product-display');
    if (!productDisplay) return;

    productDisplay.innerHTML = '';
    if (products.length === 0) return;

    products.forEach(p => {
        const div = document.createElement('div');
        div.className = 'product-card';
        const isSale = p.isSale === true || p.isSale === "true" || p.isSale === "1";
        const saleBadge = isSale ? '<span class="sale-badge">SALE</span>' : '';
        div.innerHTML = `
            <div class="product-image">
                ${saleBadge}
                <img src="${p.image}" alt="${p.name}" style="width: 100%; height: 100%; object-fit: cover;">
            </div>
            <div class="product-info">
                <h3>${p.name}</h3>
                <p>${parseFloat(p.price).toLocaleString()} VND</p>
                <button class="add-to-cart-btn" data-id="${p.id}" data-name="${p.name}" data-price="${p.price}" data-image="${p.image}">
                    <i class="fas fa-shopping-cart"></i> Thêm vào giỏ
                </button>
            </div>
        `;
        productDisplay.appendChild(div);
    });
}

function renderCart() {
    const cartItemsContainer = document.getElementById('cart-items');
    const cartTotalContainer = document.getElementById('cart-total');
    const cart = JSON.parse(localStorage.getItem('cart')) || [];

    if (!cartItemsContainer || !cartTotalContainer) return;

    if (cart.length === 0) {
        cartItemsContainer.innerHTML = '<p class="empty-cart">Giỏ hàng của bạn đang trống</p>';
        cartTotalContainer.textContent = 'Tổng: 0 VND';
        return;
    }

    let html = '';
    let subtotal = 0;

    cart.forEach((item, index) => {
        const itemTotal = item.price * item.quantity;
        subtotal += itemTotal;

        html += `
            <div class="cart-item" data-id="${item.id}">
                <img src="${item.image}" alt="${item.name}" class="cart-image" />
                <div class="item-info">
                    <h4>${item.name}</h4>
                    <p>Giá: ${parseFloat(item.price).toLocaleString()} VND</p>
                </div>
                <div class="item-quantity">
                    <button class="quantity-btn minus" data-index="${index}">-</button>
                    <input type="text" value="${item.quantity}" readonly />
                    <button class="quantity-btn plus" data-index="${index}">+</button>
                </div>
                <div class="item-total">${itemTotal.toLocaleString()} VND</div>
                <button class="remove-btn" data-index="${index}"><i class="fas fa-trash"></i></button>
            </div>
        `;
    });

    cartItemsContainer.innerHTML = html;
    cartTotalContainer.textContent = `Tổng: ${subtotal.toLocaleString()} VND`;
}

function addToCart(product) {
    const cart = JSON.parse(localStorage.getItem('cart')) || [];
    const existingItem = cart.find(item => item.id === product.id);
    if (existingItem) {
        existingItem.quantity += 1;
    } else {
        cart.push({ ...product, quantity: 1 });
    }
    localStorage.setItem('cart', JSON.stringify(cart));
    showToast(`Đã thêm ${product.name} vào giỏ hàng`);
    updateCartCount();
}

function updateCartCount() {
    const cart = JSON.parse(localStorage.getItem('cart')) || [];
    const cartCount = cart.reduce((total, item) => total + item.quantity, 0);
    const cartIcon = document.querySelector('.header-icons li a[href="cart.html"]');
    if (!cartIcon) return;

    let countBadge = cartIcon.querySelector('.cart-count');
    if (!countBadge) {
        countBadge = document.createElement('span');
        countBadge.className = 'cart-count';
        cartIcon.appendChild(countBadge);
    }
    countBadge.textContent = cartCount;
    countBadge.style.display = cartCount > 0 ? 'inline-block' : 'none';
}

function addProduct(newProduct) {
    let products = JSON.parse(localStorage.getItem('products')) || [];
    products.push(newProduct);
    localStorage.setItem('products', JSON.stringify(products));
    renderProducts();
}

function showToast(message) {
    const toast = document.createElement('div');
    toast.className = 'toast';
    toast.textContent = message;
    document.body.appendChild(toast);
    setTimeout(() => toast.remove(), 2000);
}
