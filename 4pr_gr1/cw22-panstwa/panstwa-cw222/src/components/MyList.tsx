import React, { useState } from "react";
interface Country {
  name: string;
  link: string;
}
type Props = {
  countries: Country[];
};

const MyList = (props: Props) => {
  const [countries, setCountries] = useState(props.countries);
 
  function handelChange(e: React.ChangeEvent<HTMLInputElement>): void {
    console.log(e.target.value);
    const result = props.countries.filter((elem)=>
         elem.name.includes(e.target.value)
    )
    console.log(
      result
    );

    setCountries(
      countries.filter((v) => {
        return v.name.toLowerCase().includes(e.target.value.toLowerCase());
      })
    );
  }

  return (
    <>
      <input type="text" onChange={(e) => handelChange(e)} />
      <ul className="list-group">
        {countries.map((v, k) => (
          <li className="list-group-item d-flex" key={k}>
            <div className="me-3">{v.name}</div>
            <img className="imgs" src={v.link} alt="" />
          </li>
        ))}
      </ul>
    </>
  );
};

export default MyList;
