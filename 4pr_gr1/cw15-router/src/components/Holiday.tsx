import { Gifts } from "../models/gifts"
import choinka from '../media/choinka.png'
type Props = {}

const Holiday = (props: Props) => {
  return (
    <div>
        <h3>Lista prezentów</h3>
        <img src={choinka} alt="choinka" style={{float:"right"}} />
        <ol>
            {Gifts.map((e,i)=>(
                <li key={i}>{e}</li>
            ))}
        </ol>
    </div>

  )
}

export default Holiday