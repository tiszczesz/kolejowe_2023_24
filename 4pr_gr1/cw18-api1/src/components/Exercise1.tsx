import { useState } from 'react';
import './Exercise1.css';

type Props = {}

const Exercise1 = (props: Props) => {
  const [timer,setTimer] = useState(new Date().toLocaleTimeString())
  return (
    <div className='timer' >
     {/* Tutaj aktualny czas */
      timer
     }
    </div>
  )
}

export default Exercise1