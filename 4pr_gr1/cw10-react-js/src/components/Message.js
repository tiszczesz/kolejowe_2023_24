import React from 'react'
import PropTypes from 'prop-types'

const Message = ({firstname,lastname}) => {
//const Message = (props) => {
  return (
    <div>Witaj {firstname} {lastname}</div>
    //<div>Witaj {props.firstname} {props.lastname}</div>
  )
}

Message.propTypes = {
    firstname:PropTypes.string,
    lastname:PropTypes.string
}

export default Message