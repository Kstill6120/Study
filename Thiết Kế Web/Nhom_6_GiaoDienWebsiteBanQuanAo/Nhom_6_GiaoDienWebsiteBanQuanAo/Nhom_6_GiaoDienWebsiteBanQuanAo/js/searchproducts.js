
    const products = [
    {name: "Áo thun", url: "aothun.html" },
    {name: "Áo sơ mi", url: "somi.html" },
    {name: "Áo croptop", url: "crop.html" },
    {name: "Áo hoodie", url: "hoodie.html" },
    {name: "Váy dài", url: "dai.html" },
    {name: "Full", url: "full.html" },
    {name: "Hàng bán chạy", url: "hangbanchay.html" },
    {name: "Hàng giới hạn", url: "hanggioihan.html" },
    {name: "Hàng mới", url: "hangmoi.html" },
    {name: "Quần Jeans", url: "jeans.html" },
    {name: "Kính", url: "kinh.html" },
    {name: "Mùa ngay", url: "muangay.html" },
    {name: "Nón", url: "non.html" },
    {name: "Quần ống rộng", url: "rong.html" },
    {name: "Sales", url: "sales.html" },
    {name: "Set", url: "set.html" },
    {name: "Short", url: "short.html" },
    {name: "Quần Tây", url: "tay.html" },
    {name: "Kẹp Tóc", url: "toc.html" },
    {name: "Trang sức", url: "trangsuc.html" },
    { name: "Túi", url: "tui.html" },
    { name: "Quần Baggy", url: "Baggy.html" }
    ];


    const input = document.getElementById("search-input");
    const resultBox = document.getElementById("search-results");
    const searchBar = document.querySelector(".search-bar");

        input.addEventListener("input", () => {
            const keyword = input.value.trim().toLowerCase();
    resultBox.innerHTML = "";

    if (keyword === "") {
        searchBar.classList.remove("active");
    return;
            }

            const matches = products.filter(p => p.name.toLowerCase().includes(keyword));

    if (matches.length === 0) {
        resultBox.innerHTML = "<div style='padding:10px;'>Không tìm thấy sản phẩm</div>";
            } else {
        matches.forEach(p => {
            const item = document.createElement("a");
            item.href = p.url;
            item.style.display = "block";
            item.textContent = p.name;
            resultBox.appendChild(item);
        });
            }

    searchBar.classList.add("active");
        });

        document.addEventListener("click", (e) => {
            if (!searchBar.contains(e.target)) {
        searchBar.classList.remove("active");
            }
        });

        // Giỏ hàng

        window.addEventListener('DOMContentLoaded', () => {
        updateCartCount();
        });
window.initSearch = initSearch;
window.products = products;