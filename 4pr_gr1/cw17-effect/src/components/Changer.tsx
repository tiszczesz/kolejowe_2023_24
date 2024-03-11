import React, { useEffect, useState } from "react";
import "./Changer.css";
type Props = {
  time: number;
  color: "red" | "green" | "blue" | "yellow";
};

const Changer = (props: Props) => {
  const [isBordered, setIsBordered] = useState(false);
  useEffect(() => {
    console.log("rendering changera....");

    setTimeout(() => {
      setIsBordered(!isBordered);
    }, props.time);
  }, []);
  return (
    <div
      className="changer"
      style={{ border: `solid ${isBordered ? "1px" : "0"} ${props.color}` }}
    >
      Changer
    </div>
  );
};

export default Changer;
