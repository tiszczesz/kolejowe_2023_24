import { Todo,User,getUsers, getTodos } from "./Types.js";
let todos: Todo[];
let users: User[];
todos = await getTodos();
users = await getUsers();
console.log(todos);
console.log(users);
