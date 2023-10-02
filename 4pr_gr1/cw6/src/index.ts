const input = document.createElement("input");
input.id = "input";
const button = document.createElement("button");
button.innerHTML = "Click Me";
button.className = "btn btn-primary m-2";

document.querySelector("#root")?.appendChild(input);
document.querySelector("#root")?.appendChild(button);
button.addEventListener("click", () => {
    console.log(input.value);
});
function getTime(): string {
    return new Date().toLocaleTimeString();
}

(document.querySelector("#timer") as HTMLDivElement).innerHTML = getTime();

let startID:number|undefined;
document.querySelector("#run")?.addEventListener("click", (event) => {
    
    console.log((event.target as HTMLInputElement).value);
   // debugger;
    if ((event.target as HTMLInputElement).value != "START") {
        (event.target as HTMLInputElement).value = "START";
        clearInterval(startID);
        startID = undefined;
        (document.querySelector("#timer")as HTMLSpanElement).style.color = "red";
        console.log((event.target as HTMLInputElement).value);
    } else {
        (document.querySelector("#timer") as HTMLDivElement).innerHTML = getTime();
        startID = setInterval(() => {
            (document.querySelector("#timer") as HTMLDivElement).innerHTML = getTime();
        }, 1000);
        (event.target as HTMLInputElement).value = "STOP";
        (document.querySelector("#timer")as HTMLSpanElement).style.color = "black";
    }

})