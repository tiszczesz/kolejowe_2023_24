import { useState } from "react";
import "./App.css";
import Radios from "./components/Radios/Radios";
import Select from "./components/Select/Select";

function App() {
  const [radioSelected,setRadiSelected] = useState("");
  console.log("Renderowanie App ....");
  
  return (
    <div>
      <h1>Ćwiczenie 14</h1>
      <div className="container">
        <div style={{width:"300px",margin:"20px"}}>
          <Radios
            data={[
              "To jest pierwsza informacja",
              "ala ma kota",
              "tyle starczy"
            ]}
            info="To jest mój zbiór radios"
            name="r1"
            handleChange={(val:string)=>setRadiSelected(val)}
          />
          <div style={{color:"red"}}>Wybrane z radio: {radioSelected}</div>
        </div>

        <div style={{width:"300px",margin:"20px"}}>
          <Select
            data={["opcja pierwsza", "opcja druga", "opcja trzecia"]}
            info="To jest Select"
            name="s1"
          />
        </div>
       
      </div>
    </div>
  );
}

export default App;
