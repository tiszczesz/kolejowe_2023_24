import React from 'react'

type Props = {
    time:number;
    color:"red"|"green"|"blue"|"yellow";
}

const Changer = (props: Props) => {
  return (
    <div>Changer</div>
  )
}

export default Changer