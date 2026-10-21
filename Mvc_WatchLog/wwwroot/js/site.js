// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded", function () {
    const toggleButton = document.getElementById("theme-toggle");

    // 檢查瀏覽器有沒有記住上次的設定
    const currentTheme = localStorage.getItem("theme") || "light";
    document.documentElement.setAttribute("data-theme", currentTheme);
    updateButtonText(currentTheme);

    // 點擊按鈕時切換主題
    toggleButton.addEventListener("click", function () {
        let theme = document.documentElement.getAttribute("data-theme");
        let newTheme = theme === "dark" ? "light" : "dark";

        document.documentElement.setAttribute("data-theme", newTheme);
        localStorage.setItem("theme", newTheme); // 存起來
        updateButtonText(newTheme);
    });

    function updateButtonText(theme) {
        if (theme === "dark") {
            toggleButton.innerText = "切換明亮模式 ☀️";
            toggleButton.classList.replace("btn-outline-secondary", "btn-outline-light");
        } else {
            toggleButton.innerText = "切換暗黑模式 🌙";
            toggleButton.classList.replace("btn-outline-light", "btn-outline-secondary");
        }
    }
});