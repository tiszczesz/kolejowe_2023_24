import { Gifts } from "../models/gifts"
import choinka from '../media/choinka.png'
import { useState } from "react"
type Props = {}

const Holiday = (props: Props) => {
  const [gift,setGift] = useState("");
  return (
    <div>
        <h3>Lista prezentów</h3>
        <img src={choinka} alt="choinka" style={{float:"right"}} />
        <ol>
            {Gifts.map((item,i)=>(
                <li style={{cursor:"pointer"}} onClick={(e)=>setGift((e.target as HTMLOListElement).innerText)} key={i}>{item}</li>
            ))}
        </ol>
        {gift!=="" && <div className="p-2 bg-warning rounded-2">{gift}</div>}
    </div>

  )
}

export default Holiday