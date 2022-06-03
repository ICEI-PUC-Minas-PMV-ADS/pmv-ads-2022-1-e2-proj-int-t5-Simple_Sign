const btnMobile = document.getElementById ("btnMobile");

function toggleMenu() {
    const nav = document.getElementById ("nav");
    nav.classList.toggle("active");
}

btnMobile.addEventListener("click" , toggleMenu); 