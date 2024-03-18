import { useEffect, useState } from "react";
import "./Stopper.css";

type Props = {};

const Stopper = (props: Props) => {
  const [time, setTime] = useState(0);
  const [isRun, setIsRun] = useState(false);
  

  useEffect(() => {
    let interval: NodeJS.Timer;
    if (isRun) {
      interval = setInterval(() => {
        setTime((prev) => prev + 1);
        
      }, 10);
    }

    return () => {
      clearInterval(interval);      
    };
  });
  return (
    <div className="stopper">
      <input 
        type="button"
        value="START"
        onClick={() => setIsRun(true)}
      />
        <input
        type="button"
        value="STOP"
        onClick={() => {
          setIsRun(false)          
        }}
      />
      <input
        type="button"
        value="RESET"
        onClick={() => {
          setTime(0);          
        }}
      />
    
      <div style={{ fontSize: "3rem", margin: 20 }}>{time/100}</div>
    </div>
  );
};

export default Stopper;
