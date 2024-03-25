import React, { useState } from "react";
import  './Select.css';
type Props = {
  info: string;
  data: string[];
  name: string;
};

const Select = (props: Props) => {
    const [selected,setSelected] = useState('')
  return (
    <>
      <h4 className="select">{props.info}</h4>
      <select name={props.name} onChange={(e)=>{
        setSelected(e.target.value)
      }}>
        {props.data.map((item, index) => {
          return (
            <option key={index} value={item}>
              {item}
            </option>
          );
        })}
      </select>
      <div>
        Wybrany element: {selected}
      </div>
    </>
  );
};

export default Select;
