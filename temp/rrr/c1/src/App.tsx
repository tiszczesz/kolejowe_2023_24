import React, { useState } from 'react';
import logo from './logo.svg';
import './App.css';
import MyRange from './components/MyRange';

function App() {
  const [valueRed, setValueRed] = useState("255");
  const [valueGreen, setValueGreen] = useState("255");
  const [valueBlue, setValueBlue] = useState("255");
  document.body.style.backgroundColor = `rgb(${valueRed},${valueGreen},${valueBlue})`;
  return (
    <div >
    <MyRange min={0} max={255} 
    handleChange={(value: string) => setValueRed(value)} intValue={255} 
    name={'red'} />
     <MyRange min={0} max={255} 
    handleChange={(value: string) => setValueGreen(value)} intValue={255} 
    name={'green'} />
     <MyRange min={0} max={255} 
    handleChange={(value: string) => setValueBlue(value)} intValue={255} 
    name={'blue'} />
    <span>Range: {valueRed},{valueGreen}, {valueBlue}</span>
    </div>
  );
}

export default App;
