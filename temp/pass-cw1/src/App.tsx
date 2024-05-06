import React, { useState } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle';
import './App.css';
import LeftPanel from './components/LeftPanel';
import obr0 from './Images/000-zdjecie.jpg';
import obr00 from './Images/000-odcisk.jpg';
import obr1 from './Images/111-zdjecie.jpg';
import obr11 from './Images/111-odcisk.jpg';
import obr3 from './Images/333-zdjecie.jpg';
import obr33 from './Images/333-odcisk.jpg';
import { Colors } from './data/colors';

function App() {
  const [image1, setImage1] = useState(obr0);
  const [image2, setImage2] = useState(obr00);
  const [firstname, setFirstname] = useState('');
  const [lastname, setLastname] = useState('');
  const [checked,setChecked] = useState(0)
  const onHandleBlur = (v: string) => {
    console.log(v);

    switch (v) {
      case '000':
        setImage1(obr0);
        setImage2(obr00);
        break;
      case '111':
        setImage1(obr1);
        setImage2(obr11);
        break;
      case '333':
        setImage1(obr3);
        setImage2(obr33);
        break;
      default:
        setImage1(obr0);
        setImage2(obr00);
    }
  };
  const onFirstnameChange = (firstname: string) => {
    setFirstname(firstname);
  };
  const onLastnameChange = (lastname: string) => {
    setLastname(lastname);
  };
  return (
    <div className="row m-3">
      <LeftPanel
        // checked={checked}
        colors = {Colors}
        handleBlur={(e) => onHandleBlur(e)}
        className="col-6"
        handleFirstname={(f) => onFirstnameChange(f)}
        handleLastname={(last) => onLastnameChange(last)}
      />
      <div className="col-6">
        <img src={image1} alt="obrazek" />
        <img src={image2} alt="obrazek" />
        <br />
        <input
          type="button"
          value="OK"
          className="w-50 p-2 m-2"
          onClick={() => {
            alert(`Zmieniono dane: \n imie: ${firstname}\n Nazwisko: ${lastname}`);
          }}
        />
      </div>
    </div>
  );
}

export default App;
