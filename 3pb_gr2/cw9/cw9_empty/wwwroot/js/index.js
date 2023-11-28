const div = document.createElement("div");
div.innerHTML = "Ala ma kota";

setTimeout(() => {
    document.body.appendChild(div);
}, 3000);