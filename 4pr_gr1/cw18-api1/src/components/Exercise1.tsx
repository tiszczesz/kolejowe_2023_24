import { useEffect, useState } from "react";
import "./Exercise1.css";
import Stopper from "./Stopper/Stopper";

type Props = {};

const Exercise1 = (props: Props) => {
  const [timer, setTimer] = useState(new Date().toLocaleTimeString());
 

  useEffect(() => {
    
      setInterval(() => {
        setTimer(new Date().toLocaleTimeString());
      }, 1000);
      }, []);
  return (
    <div className="d-flex">
    
      <div className="timer">{/* Tutaj aktualny czas */ timer}</div>
      <Stopper />
    </div>
  );
};

export default Exercise1;
