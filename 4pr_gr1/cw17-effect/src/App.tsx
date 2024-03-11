import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle';
import './App.css';
import { useEffect, useRef } from 'react';

function App() {
  console.log("Renderowanie: ");
  let time = "ggg";

  const inputRef = useRef<HTMLInputElement>(null);
  const divRef = useRef<HTMLDivElement>(null);
  // if(inputRef.current){
  //   console.log(inputRef.current);
  //   inputRef.current.focus();
  // }else{
  //   console.log("ref: ",inputRef);
  setTimeout(()=>{
      document.title = "ala ma kota";
      // time = new Date().toLocaleTimeString();  
      if(divRef.current){
    divRef.current.innerText = new Date().toLocaleTimeString();
    time = new Date().toLocaleTimeString();
  }
  },2000)

    
  // }
  useEffect(()=>{
    if(inputRef.current){
      inputRef.current.focus();
      console.log(inputRef.current);
      
    }
    
  })
  return (
    <div className="container">
      <h1>Hello in {new Date().getFullYear()} year</h1>
      <label style={{display:'inline-block',margin:20}} htmlFor="firstname">Podaj imię: </label>
      <input ref={inputRef} type="text" id="firstname" />
      <div ref={divRef}></div>
      <div >{time}</div>
    </div>
  );
}

export default App;
