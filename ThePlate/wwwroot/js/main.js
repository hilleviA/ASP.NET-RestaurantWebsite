//Gör så att mobilmenyn fälls ut
const burger = document.querySelector(".hamburger");
const links = document.querySelector(".links");
const listItem = document.querySelectorAll(".links li");

burger.addEventListener("click", () => {
    links.classList.toggle("open");
});

links.addEventListener("click", () => {
    links.classList.toggle("open");
});