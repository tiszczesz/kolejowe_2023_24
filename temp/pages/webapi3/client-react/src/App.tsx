
import { useEffect } from 'react';
import './App.css';

function App() {
  useEffect(()=>{
    fetch("https://localhost:7202/WeatherForecast").then(response=>response.json())
    .then(data=>console.log(data));   
  })
  return (
    <div className="App">
      
    </div>
  );
}

export default App;
