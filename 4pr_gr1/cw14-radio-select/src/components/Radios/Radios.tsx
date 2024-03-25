import { useState } from "react";

type Props = {
  data: string[];
  name: string;
  info: string;
  handleChange: (val:string)=>void;
};

const Radios = ({ data, info, name,handleChange }: Props) => {
  const [selected, setSelected] = useState("");
  console.log("Renderowanie Radios ....");
  return (
    <>      
      <h4>{info}</h4>
      {data.map((value, index) => (
        <div key={"g-"+index}>
          <input 
            key={index} 
            type="radio"
            name={name}
            value={value}
            onChange={(e) => {
              setSelected(e.target.value);
              handleChange(value)
            }}
          />
          <label key={"label-"+index}>{value}</label>
          <br key={"br-"+index} />
        </div>
      ))}
      <div>Wybrany element: {selected}</div>
    </>
  );
};

export default Radios;
