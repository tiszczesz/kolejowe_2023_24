import React, { useState } from "react";

type Props = {};
const getTime = () => {
  return new Date().toLocaleTimeString();
};
const Timer = (props: Props) => {
  console.log("rendering Timer");

  const [time,setTime] = useState(getTime())
  //let time = getTime();
  setInterval(() => {
   // time = getTime();
   setTime(getTime())
  }, 1000);
  return <div style={{ fontSize: "30px" }}>timer: {time}</div>;
};

export default Timer;
