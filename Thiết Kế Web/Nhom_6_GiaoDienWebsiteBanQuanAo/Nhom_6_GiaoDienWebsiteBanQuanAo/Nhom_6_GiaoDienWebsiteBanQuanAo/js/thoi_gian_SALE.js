document.addEventListener("DOMContentLoaded", function () {
    var countdownElement = document.getElementById("countdown");
    var endTime = new Date("june 12, 2025 10:15:00").getTime();

    function updateCountdown() {
        var now = new Date().getTime();
        var timeLeft = endTime - now;

        if (timeLeft <= 0) {
            countdownElement.textContent = "Kết thúc trong: 00h 00m 00s";
            clearInterval(timer);
            updateSaleStatus();
            return;
        }

        var hours = Math.floor((timeLeft % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
        var minutes = Math.floor((timeLeft % (1000 * 60 * 60)) / (1000 * 60));
        var seconds = Math.floor((timeLeft % (1000 * 60)) / 1000);

        countdownElement.textContent = `Kết thúc trong: ${hours}h ${minutes}m ${seconds}s`;
    }

    function updateSaleStatus() {
        var productCards = document.querySelectorAll(".product-card");

        productCards.forEach(function (card) {
            var originalPrice = card.querySelector(".original-price");
            var salePrice = card.querySelector(".sale-price");
            var saleBadge = card.querySelector(".sale-badge");

            if (salePrice) salePrice.style.display = "none";
            if (originalPrice) originalPrice.style.textDecoration = "none";
            if (saleBadge) saleBadge.style.display = "none";
        });
    }

    var timer = setInterval(updateCountdown, 1000);
});
document.addEventListener("DOMContentLoaded", function () {
    var countdownElement = document.getElementById("countdown");
    var endTime = new Date("june 12, 2025 10:15:00").getTime();

    function updateCountdown() {
        var now = new Date().getTime();
        var timeLeft = endTime - now;

        if (timeLeft <= 0) {
            countdownElement.textContent = "Kết thúc trong: 00h 00m 00s";
            clearInterval(timer);
            updateSaleStatus();
            return;
        }

        var hours = Math.floor((timeLeft % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
        var minutes = Math.floor((timeLeft % (1000 * 60 * 60)) / (1000 * 60));
        var seconds = Math.floor((timeLeft % (1000 * 60)) / 1000);

        countdownElement.textContent = `Kết thúc trong: ${hours}h ${minutes}m ${seconds}s`;
    }

    function updateSaleStatus() {
        var productCards = document.querySelectorAll(".product-card");

        productCards.forEach(function (card) {
            var originalPrice = card.querySelector(".original-price");
            var salePrice = card.querySelector(".sale-price");
            var saleBadge = card.querySelector(".sale-badge");

            if (salePrice) salePrice.style.display = "none";
            if (originalPrice) originalPrice.style.textDecoration = "none";
            if (saleBadge) saleBadge.style.display = "none";
        });
    }


    var timer = setInterval(updateCountdown, 1000);
});