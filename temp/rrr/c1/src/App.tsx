import React, { useState } from 'react';
import logo from './logo.svg';
import './App.css';
import MyRange from './components/MyRange';
import MyRadio from './components/MyRadio';

function App() {
  const [valueRed, setValueRed] = useState("255");
  const [valueGreen, setValueGreen] = useState("255");
  const [valueBlue, setValueBlue] = useState("255");
  const [radioValue,setRadioValue] = useState("");
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

    <div>
      <MyRadio data={["232323","wrwrwrwr","etetetetet"]} name='ddd' initVal='' 
      handleChanges={(value:string)=>{setRadioValue(value)}} />
      <span>Zmienione radio: {radioValue}</span>
    </div>
    </div>
  );
}

export default App;
