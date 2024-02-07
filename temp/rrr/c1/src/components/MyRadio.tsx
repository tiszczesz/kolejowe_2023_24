import React from "react";

type Props = {
  data: string[];
  name: string;
  initVal: string;
  handleChanges: (val: string) => void;
};

const MyRadio = ({ name, data, initVal, handleChanges }: Props) => {
    const [myValue, setMyValue] = React.useState(initVal);
  return (
    <>
      <div>{name}</div>
      {data.map((val, index) => {
        return (
          <div key={index}>
            <input
              type="radio"
              name={name}
              value={val}
              onChange={(e) => {
                setMyValue(e.target.value);
                handleChanges(val);

            }
            }
            />
            <label>{val}</label>
          </div>
        );
      })}

      <div>Selected: {myValue}</div>
    </>
  );
};
export default MyRadio;
