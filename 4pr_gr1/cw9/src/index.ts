import { colors } from "./dane";
const elem = document.createElement("div");
elem.innerHTML = "ala ma kota";
document.querySelector(".container")?.appendChild(elem);
console.log(colors);
