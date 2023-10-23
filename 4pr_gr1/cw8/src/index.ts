import { Todo, User, getUsers, getTodos } from "./Types.js";
let todos: Todo[];
let users: User[];
todos = await getTodos();
users = await getUsers();
console.log(todos);
console.log(users);
const rootNode = document.querySelector("#root") as HTMLDivElement;
const usersNode = document.querySelector("#users") as HTMLDivElement;
UsersToList(usersNode, users);
function UsersToList(node: HTMLDivElement | null, users: User[]): void {
    const list = document.createElement("ul");
    list.className = "list-group"
    for (const u of users) {
        const li = document.createElement("li");
        li.id = u.id.toString();
        li.className = "list-group-item";
        li.innerHTML = `${u.name} <span style="color:blue;font-weight:bold">${u.username}</span><br /> email: ${u.email}`;
        li.addEventListener("click", (event) => {
            const elem = event.target as HTMLDataListElement;
            const todosFilter = todos.filter((e) => {
                return (e.userId.toString() === elem.id);
            })
            console.log(todosFilter);

            // rootNode.innerHTML = `zadania do wykonania dla: ${elem.id}`;
            rootNode.innerHTML = "";
            generTodos(todosFilter)
        })
        list.appendChild(li);
    }
    node?.appendChild(list);
}
function generTodos(todos: Todo[]) {
    todos.forEach((elem) => {
        rootNode.appendChild(generCard(elem))
    })
}
generTodos(todos);

function generCard(todo: Todo): Element {
    const style = todo.completed ? 'style="color:green"' : 'style="color:red"';
    const card = document.createElement('div');
    card.className = 'card m-1';
    card.style.width = "18rem";
    card.innerHTML = `
            <div class="card" style="width: 18rem;">
        
        <div class="card-body">
            <h5 class="card-title">Do zrobienia dla
             ${(users.find((u) => u.id === todo.userId))?.username}</h5>
            <p class="card-text" ${style}>${todo.title}</p>
            
        </div>
        </div>
    `
    return card;
}
