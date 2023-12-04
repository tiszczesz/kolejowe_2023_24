import { useState } from "react";

type Props = {
  data: string[];
  name: string;
  info: string;
};

const Radios = ({ data, info, name }: Props) => {
  const [selected, setSelected] = useState("");
  return (
    <>
      <hr />
      <h3>{info}</h3>
      {data.map((v, i) => (
        <>
          <input
            key={i}
            type="radio"
            name={name}
            value={v}
            onChange={(e) => {
              setSelected(e.target.value);
            }}
          />
          <label>{v}</label>
          <br />
        </>
      ))}

      <div>Wybrany element: {selected}</div>
    </>
  );
};

export default Radios;
