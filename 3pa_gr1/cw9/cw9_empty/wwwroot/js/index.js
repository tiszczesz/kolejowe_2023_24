const div = document.createElement("div");
div.id = "timer";
document.body.appendChild(div);
function Timer(){
    return new Date().toLocaleTimeString();
}
document.querySelector("#timer").innerHTML = Timer();
setInterval(()=>{
    document.querySelector("#timer").innerHTML = Timer();
},1000);