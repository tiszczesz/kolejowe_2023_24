import React, { useState } from 'react'

type Props = {
    name:string;
    max:number;
    min:number;
    intValue :number;
    handleChange:(value:string)=>void;
}

const MyRange = ({name,max,min,intValue,handleChange}: Props) => {
    const [myValue,setMyValue]=useState(intValue)
  return (
    <div>
    <span>{name} value: {myValue}</span>
        <input type="range" onChange={(e)=>{
            setMyValue(parseInt(e.target.value));
            handleChange(e.target.value);
        }} min={min} max={max} value={myValue}/>
    </div>
  )
}

export default MyRange