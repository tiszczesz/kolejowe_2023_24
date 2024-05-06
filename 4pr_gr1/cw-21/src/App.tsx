import { useState } from "react";
import "./App.css";
import LeftComp from "./components/LeftComp";
import Nav from "./components/Nav";
import RightComp from "./components/RightComp";
import { Todo, Todos } from "./Data/TodosData";
import TodosContext from "./contexts/todosContext";
import TodoForm from "./components/TodoForm";


function App() {
  const [todos, setTodos] = useState<Todo[]>(Todos);
  const [show,setShow]=useState<boolean>(false);
  const handleDelete = (t:Todo)=>{
    console.log(`usuwanie elementu: ${t}`);
    setTodos((prev)=>prev.filter((item)=>{return item.id!==t.id}))
  }
  const handleInsert = (t:Todo)=>{
    console.log(t);
    setTodos(prev=>[...prev,t])
  }
  return (
    <div className="container">
      <TodosContext.Provider value={{todos,handleDelete,handleInsert}}>
        <Nav />
        <div className="d-flex" style={{ gap: 50 }}>
          <LeftComp className="w-50 mt-3" style={{ color: "blue" }} />
          <RightComp
            className="w-50 mt-3"
            style={{ border: "solid 1px grey", padding: "10px" }}
          />
        </div>
        <button className="w-50 btn btn-info m-3" onClick={()=>{setShow(f=>!f);console.log(show)}} >Dodaj zadanie</button>
        {show && <TodoForm />}
      </TodosContext.Provider>
    </div>
  );
}

export default App;
