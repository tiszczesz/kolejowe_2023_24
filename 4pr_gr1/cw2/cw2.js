const root = document.querySelector("#root");

//utworzyc liste todos
const todos = [
    ['zrobić ćwiczenie',true],
    ['zgłosić zrobione ćwiczenie',false],
    ['cieszyć się brakiem bańki z aktywności',false]
];
//wygenerowac ul za pomocą createElement
const ul = document.createElement("ul");
//w petli wygenerowac li za pomocą createElement
for(let elem of todos){
    console.log(elem);
    const li = document.createElement("li");
    const text = document.createTextNode(elem[0]);
    li.appendChild(text);
    //dodac do ul liste li appendChild
    ul.appendChild(li);
}
todos.forEach((v)=>{
    console.log(v);}
    );

//dodac do root calosc
root.appendChild(ul);
