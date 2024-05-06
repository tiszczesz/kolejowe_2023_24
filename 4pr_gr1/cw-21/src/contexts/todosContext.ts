import React from "react";
import { Todo } from "../Data/TodosData";

interface TodosContextType{
    todos:Todo[],
    handleDelete:(todo: Todo)=>void,
    handleInsert:(todo:Todo)=>void
}

const TodosContext = React.createContext<TodosContextType | null>(null);
export default TodosContext;