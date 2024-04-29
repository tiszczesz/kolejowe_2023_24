import React, { ComponentProps, useContext } from "react";
import TodosContext from "../contexts/todosContext";

type Props = ComponentProps<any> & {};

const LeftComp = (props: Props) => {
  const context = useContext(TodosContext);
  return (
    <div className={props.className} style={props.style}>
      <h2>Lista zadań</h2>
      <table className="table table-striped">
        <thead>
          <tr>
            <th>Nazwa zadania</th>
            <th>Zawartość zadania</th>
            <th>Data rejestracji zadania</th>
            <th></th>
          </tr>
        </thead>
        <tbody>
          {context?.todos.map((v) => (
            <tr key={v.id}>
              <td>{v.title}</td>
              <td>{v.content}</td>
              <td>{v.date.toLocaleDateString()}</td>
              <td>                
                <button onClick={()=>context.handleDelete(v)} className="btn btn-danger">Usuń</button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default LeftComp;
