import React, { ComponentProps } from 'react';

type Props = ComponentProps<'div'> & {
  colors: string[];
  //checked:number;
  handleFirstname: (firstname: string) => void;
  handleLastname: (lastname: string) => void;
  handleBlur: (image: string) => void;
};

const LeftPanel = (props: Props) => {
    
    
  return (
    <div className={props.className}>
      <div className="row m-2">
        <label className="col-3">Numer</label>
        <input
          className="col-3"
          type="text"
          onBlur={(e) => props.handleBlur(e.target.value)}
        />
      </div>
      <div className="row m-2">
        <label className="col-3">Imię</label>
        <input
          className="col-3"
          type="text"
          onChange={(e) => props.handleFirstname(e.target.value)}
        />
      </div>
      <div className="row m-2">
        <label className="col-3">Nazwisko</label>
        <input
          className="col-3"
          type="text"
          onChange={(e) => props.handleLastname(e.target.value)}
        />
      </div>
      <div className="border">
        {props.colors.map((v, k) => (
          <>
            <input  name='kolory' key={k} type="radio" value={v} /> {v} <br />
          </>
        ))}
      </div>
    </div>
  );
};

export default LeftPanel;
