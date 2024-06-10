import "bootstrap/dist/css/bootstrap.min.css";
import "./App.css";
import { FormEvent, useRef, useState } from "react";
import { MyList, Person } from "./lista";
function getMaxId(list: Person[]): number | null {
  if(list.length===0) return null;
  return list.reduce((acc,p)=>Math.max(acc,p.id),-Infinity)
}
function App() {
  const [list, setList] = useState<Person[]>(MyList);
  const [show, setShow] = useState<boolean>(false);
  const formRef = useRef<HTMLFormElement>(null);
  function handleDelete(id: number): void {
    console.log("usuwanie: " + id);
    //setList([...stare,nowy])   dodawanie
    setList(list.filter((elem) => elem.id !== id)); //usuwanie
  }

  function handleSubmit(e: FormEvent<HTMLFormElement>): void {
    e.preventDefault();
    if (formRef.current !== null) {
      const formData = new FormData(formRef.current);
      // const ids = list.map((e) => e.id);
      // const maxId = Math.max(...ids) + 1;
      const maxId = getMaxId(list)??-Infinity;
      const newPerson: Person = {
        id: maxId+1,
        firstname: formData.get("firstname")?.toString(),
        lastname: formData.get("lastname")?.toString(),
        age: parseInt(formData.get("age")?.toString()!),
      };
      console.log(formData);
      setList((prev) => [...prev, newPerson]);
      console.log(list);
      
    }
  }

  return (
    <div className="container">
      <h1>Lista osób: {list.length}</h1>
      <div>
        <button
          className="btn btn-outline-warning"
          onClick={() => setShow(!show)}
        >
          {show ? "Ukryj" : "Pokaż"}
        </button>
        {show && (
          <form ref={formRef} onSubmit={(e) => handleSubmit(e)}>
            <input
              required
              name="firstname"
              className="m-1"
              type="text"
              placeholder="imię"
            />
            <br />
            <input
              required
              name="lastname"
              className="m-1"
              type="text"
              placeholder="nazwisko"
            />
            <br />
            <input
              required
              name="age"
              className="m-1"
              type="number"
              placeholder="wiek"
            />
            <br />
            <button className="btn btn-primary m-1" type="submit">
              Dodaj
            </button>
          </form>
        )}
      </div>
      <table className="table table-striped">
        <thead>
          <tr>
            <th>Lp</th>
            <th>Imię</th>
            <th>Nazwisko</th>
            <th>Wiek</th>
            <th>----</th>
          </tr>
        </thead>
        <tbody>
          {list.map((p, i) => (
            <tr key={p.id}>
              <td>{i + 1}</td>
              <td>{p.firstname}</td>
              <td>{p.lastname}</td>
              <td style={{ textAlign: "right" }}>{p.age}</td>
              <td>
                <button
                  onClick={() => handleDelete(p.id)}
                  className="btn btn-danger"
                >
                  x
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default App;
