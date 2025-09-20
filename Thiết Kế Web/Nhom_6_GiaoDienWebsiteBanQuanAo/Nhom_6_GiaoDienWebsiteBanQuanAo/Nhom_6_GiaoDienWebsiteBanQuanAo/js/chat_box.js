document.addEventListener("DOMContentLoaded", function () {
    const chatToggle = document.getElementById("chat-toggle");
    const chatBox = document.getElementById("chat-box");
    const sendBtn = document.getElementById("send-btn");
    const chatInput = document.getElementById("chat-input");
    const messages = document.getElementById("messages");
    const quickButtons = document.querySelectorAll(".quick-buttons button");
    const greeting = document.getElementById("chat-greeting");

    // Mở / đóng chat box
    chatToggle.addEventListener("click", () => {
        if (chatBox.style.display === "none" || chatBox.style.display === "") {
            chatBox.style.display = "flex";
            greeting.style.display = "none"; // Ẩn lời chào khi mở chat
            chatInput.focus();
        } else {
            chatBox.style.display = "none";
            greeting.style.display = "block"; // Hiện lại lời chào khi đóng
        }
    });

    function addUserMessage(text) {
        const userMsg = document.createElement("div");
        userMsg.className = "user-msg";
        userMsg.textContent = text;
        messages.appendChild(userMsg);
        messages.scrollTop = messages.scrollHeight;
    }

    function addBotMessage(text) {
        const botReply = document.createElement("div");
        botReply.className = "bot-msg";
        botReply.textContent = text;
        messages.appendChild(botReply);
        messages.scrollTop = messages.scrollHeight;
    }

    function botReplyFor(text) {
        const replies = {
            "Tôi muốn đổi trả": "Bạn vui lòng cung cấp mã đơn hàng và lý do đổi trả để chúng tôi hỗ trợ nhé.",
            "Tôi cần tư vấn size": "Bạn hãy cho biết chiều cao, cân nặng hoặc số đo để chúng tôi tư vấn size phù hợp.",
            "Vấn đề giao hàng": "Vui lòng cung cấp mã đơn hàng để kiểm tra tình trạng giao.",
            "Khác": "Bạn vui lòng mô tả rõ hơn vấn đề để chúng tôi hỗ trợ nhanh nhất."
        };
        return replies[text] || "Cảm ơn bạn đã nhắn! Chúng tôi sẽ phản hồi sớm.";
    }

    function sendMessage(text) {
        if (!text.trim()) return;
        addUserMessage(text.trim());
        chatInput.value = "";

        setTimeout(() => {
            addBotMessage(botReplyFor(text.trim()));
        }, 500);
    }

    sendBtn.addEventListener("click", () => {
        sendMessage(chatInput.value);
    });

    chatInput.addEventListener("keypress", function (e) {
        if (e.key === "Enter") {
            e.preventDefault();
            sendMessage(chatInput.value);
        }
    });

    quickButtons.forEach(button => {
        button.addEventListener("click", () => {
            const msg = button.getAttribute("data-msg");
            sendMessage(msg);
            chatInput.focus();
        });
    });
});