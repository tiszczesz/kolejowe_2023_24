import "./App.css";
import Radios from "./components/Radios/Radios";

function App() {

  return (
    <div>
      <h1>To jest moje eeeee</h1>
      <Radios
        data={["To jest pierwsza informacja", "ala ma kota", "tyle starczy"]}
        info="To jest mój zbiór radios"
        name="r1"
      />
    </div>
  );
}

export default App;
