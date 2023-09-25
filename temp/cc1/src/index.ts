console.log("hello");

const div = document.createElement("div");
const text = document.createTextNode("rr    rrrrr");
div.appendChild(text);

document.querySelector("#root")?.appendChild(div);
