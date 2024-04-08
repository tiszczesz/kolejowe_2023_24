import "./App.css";
import { Trip, Trips } from "./data/data";
function App() {
  let total = 0;
  for(let sum of Trips){
    total += sum.price;
  }
  return (
    <div className="container">
      <h1>Wycieczki 2024</h1>
      <h3>Ilość wycieczek: {Trips.length}</h3>
      <ul>
        {Trips.map((elem,index)=>(
          <li key={index}>{elem.place}</li>
        ))}
      </ul>
      <div>Koszt wycieczek: {total} {Trips.reduce((total,item)=>total+item.price,0) }</div>
    </div>
  );
}

export default App;
