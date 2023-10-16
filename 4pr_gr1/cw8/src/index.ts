import { Todo, getTodos } from "./Types.js";
let todos: Todo[];

todos = await getTodos();
console.log(todos);
