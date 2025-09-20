document.querySelectorAll('.dropdown > a').forEach(item => {
    item.addEventListener('click', function (e) {
        e.preventDefault();
        const submenu = this.nextElementSibling;
        if (submenu) {
            submenu.style.display = submenu.style.display === 'block' ? 'none' : 'block';
        }
    });
});
