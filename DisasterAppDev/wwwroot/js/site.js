// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Table Row Highlight on Hover
document.addEventListener("DOMContentLoaded", function () {
    const rows = document.querySelectorAll("table tbody tr");
    rows.forEach(row => {
        row.addEventListener("mouseover", () => {
            row.style.backgroundColor = '#f0f8ff'; // Light Blue
        });
        row.addEventListener("mouseout", () => {
            row.style.backgroundColor = ""; // Reset
        });
    });
});

// Form Validation
document.addEventListener("DOMContentLoaded", function () {
    const form = document.querySelector("form");

    if (form) {
        form.addEventListener("submit", function (event) {
            const nameInput = document.querySelector("#Name");
            if (nameInput && nameInput.value.trim() === "") {
                event.preventDefault();
                alert("Name is required");
            }
        });
    }
});


// Fetching Data and Update Table
document.addEventListener("DOMContentLoaded", function () {
    const refreshButton = document.querySelector("#refreshButton");
    if (refreshButton) {
        refreshButton.addEventListener("click", async function () {
            const response = await fetch("/api/testmodels");
            const data = await response.json();
            const tableBody = document.querySelector("table tbody");
            tableBody.innerHTML = ""; // Clear existing rows
            data.forEach(item => {
                const row = `<tr>
                    <td>${item.id}</td>
                    <td>${item.name}</td>
                    <td>${item.age}</td>
                    <td>${item.description}</td>
                `;
                tableBody.innerHTML += row;
            });
        });
    }
});

// Dark Mode
document.addEventListener("DOMContentLoaded", function () {
    const toggleButton = document.querySelector("#darkModeToggle");
    if (toggleButton) {
        toggleButton.addEventListener("click", () => {
            document.documentElement.classList.toggle("dark")
        });
    }
});


// Smooth scroll to top
document.addEventListener("DOMContentLoaded", function () {
    const scrollToTopButton = document.querySelector("#scroolToTop");
    if (scrollToTopButton) {
        scrollToTopButton.addEventListener("click", () => {
            window.scrollTo({ top: 0, behavior: "smooth" });
        });;;;
    }
});
