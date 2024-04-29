import React, { ComponentProps } from 'react'
import Info from './Info'

type Props = ComponentProps<'div'> &  {}

const RightComp = (props: Props) => {
  return (
    <div style={props.style} className={props.className} >
        <h2>Panel informacyjny</h2>
        <Info />
    </div>
  )
}

export default RightComp