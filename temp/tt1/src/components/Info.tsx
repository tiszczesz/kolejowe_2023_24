import React, { useState } from 'react'

type Props = {}

const Info = (props: Props) => {
    const [text ,setText]= useState("początek")
    console.log("rendering Info");
    
    //let text = "kkkkk";
  return (
    <div>
        <input type="text" name="info" id="info" value={text} onChange={(e)=>setText(e.target.value)} />
        <p>{text}</p>
    </div>
  )
}

export default Info