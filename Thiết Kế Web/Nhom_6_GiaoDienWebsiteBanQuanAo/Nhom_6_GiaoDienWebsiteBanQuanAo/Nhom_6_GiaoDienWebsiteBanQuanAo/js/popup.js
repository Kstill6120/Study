document.addEventListener("DOMContentLoaded", function () {
    // Hiện popup sau 3 giây
    setTimeout(function () {
        document.getElementById("popup-ad").style.display = "flex";
    }, 3000);

    // Đóng popup khi bấm nút X
    document.querySelector(".close-popup").addEventListener("click", function () {
        document.getElementById("popup-ad").style.display = "none";
    });

    // Khi bấm "Mua ngay", ẩn popup và cuộn tới phần sale
    document.querySelector(".popup-button").addEventListener("click", function () {
        document.getElementById("popup-ad").style.display = "none";
        document.querySelector("#sale-products").scrollIntoView({ behavior: "smooth" });
    });
});