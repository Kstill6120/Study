document.querySelectorAll(".offer-card button").forEach(button => {
        button.addEventListener("click", function () {
            const code = this.parentElement.querySelector("p strong").nextSibling.textContent.trim();
            // Tạo thẻ input tạm để sao chép
            const tempInput = document.createElement("input");
            tempInput.value = code;
            document.body.appendChild(tempInput);
            tempInput.select();
            document.execCommand("copy");
            document.body.removeChild(tempInput);
            // Thông báo
            alert(`Đã sao chép mã: ${code}`);
        });
    });