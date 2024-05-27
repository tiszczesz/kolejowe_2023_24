import "bootstrap/dist/css/bootstrap.min.css";

import "./App.css";
import { FormEvent, useState } from "react";

function App() {
  const courses = [
    "Programowanie w c#",
    "Angular dla początkujących",
    "Kurs Django",
  ];
  const colors = ["dddd", "gggg", "yyyyy"];

  function handleSubmit(e: FormEvent<HTMLFormElement>): void {
    e.preventDefault();
    console.log(user);
    const course_info = courses[course - 1];
    if (course_info !== undefined) {
      console.log(course_info);
      setResult(`${user} zapisany na ${course_info}`)
    } else {
      console.log("Nieprawidłowy numer kursu");
      setResult(`${user} zapisany na: Nieprawidłowy numer kursu`)
    }
  }
  const [user, setUser] = useState("");
  const [course, setCourse] = useState(0);
  const [result,setResult] = useState("");
  return (
    <div className="container">
      <h2>Liczba kursów: {courses.length}</h2>
      <ol>
        {courses.map((c, i) => (
          <li key={i}>{c}</li>
        ))}
      </ol>
      {/* <select>
        {colors.map((c, i) => (
          <option value={c}>{c}</option>
        ))}
      </select> */}
      <form onSubmit={(e) => handleSubmit(e)}>
        <div className="form-group m-2">
          <label>Imię i nazwisko:</label>
          <input
            onChange={(e) => setUser(e.target.value)}
            type="text"
            className="form-control"
          />
        </div>
        <div className="form-group m-2">
          <label>Numer kursu:</label>
          <input
            onChange={(e) => setCourse(parseInt(e.target.value))}
            type="number"
            className="form-control"
          />
        </div>
        <input
          className="btn btn-primary m-2"
          type="submit"
          value="Zapisz do kursu"
        />
      </form>
      <div>{result}</div>
    </div>
  );
}

export default App;
