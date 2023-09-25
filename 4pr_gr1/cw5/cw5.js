class Student {
  constructor(firstname, lastname, age = 18, division = "4PR") {
    this.firstname = firstname;
    this.lastname = lastname;
    this.age = age;
    this.division = division;
  }
  show() {
    return `
            <div>
             ${this.toString()}
            </div>
        `;
  }
  setDivision(division) {
    this.division = division;
  }
  toString(){
    return `Imię: ${this.firstname} Nazwisko: ${this.lastname}
    wiek: ${this.age} oddział: ${this.division}`;
  }
}

const s1 = new Student("Antoni", "Derecki");
const students = [
  new Student("Renata", "Tooo", 45, "2a"),
  new Student("Tomasz", "Bomasz", 32, "2a"),
  new Student("Alojzy", "Tooo", 17, "2a"),
  new Student("Grażyna", "Tooo", 22, "2a"),
  new Student("Renata", "Tooo", 45, "2a"),
];
function generList(list) {
  const ul = document.createElement("ul");
  list.forEach((s) => {
    const li = document.createElement("li");
    const text = document.createTextNode(`${s.firstname} ${s.lastname} 
                   wiek: ${s.age} dział: ${s.division}`);
    li.appendChild(text);
    ul.appendChild(li);
  });

  return ul;
}

function generMapList(list){
    const lis = list.map((s)=>(`<li>${s.toString()}</li>`));
    const ul = document.createElement("ul");
    let html = "";
    for(const li of lis){
        ul.innerHTML+= li;
    }
    console.log(html);
   // ul.innerHTML = html;
    return ul;
}

for (const elem in s1) {
  console.log(elem);
}
for (const elem of Object.values(s1)) {
  console.log(elem);
}
for (const elem of Object.keys(s1)) {
  console.log(elem);
}
//console.log(s1["firstname"]);
const result = students.map((val, index) => {
  return `<li>${val.firstname}</li>`;
});
console.log(result);
document.querySelector("#p1").appendChild(generList(students));
document.querySelector("#p2").appendChild(generMapList(students));
