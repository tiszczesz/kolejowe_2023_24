import React, { useState } from 'react'

type Props = {}

function Message({}: Props) {
    console.log("rendering Message...");
    //let text = "ala ma k";
    const [text,setText] = useState("ala ma kota")
   // console.log(text);
    
  return (
    <div>
        <input type='text' 
        value={text}
        onChange={(e)=>setText(e.target.value)}/>
        <p>{text}</p>
    </div>
  )
}

export default Message