import React from 'react';
import './Message.css';
import { User } from '../users';

type MessageProps = {
    user:User
}

const Message = (props: MessageProps) => {
  return (
    <div style={{margin:"10px"}}>
        <h1>Wizytówka użytkownika</h1>
        <h4>Imię: <span className='info'>
            {props.user.firstname}</span></h4>
        <h4>Nazwisko: <span className='info'>
            {props.user.lastname}</span></h4>
        <h5>Wiek: <span className='info'>
            {props.user.age}</span></h5>
        <hr />
    </div>
  )
}

export default Message