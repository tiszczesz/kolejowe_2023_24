import React from 'react'
import { Link } from 'react-router-dom'

type Props = {}

const Nav = (props: Props) => {
  return (
    <ul className='list-group'>
        <li className='list-group-item'>
            <Link to={'/'}>Strona Główna</Link>
        </li>
        <li className='list-group-item'>
            <Link to={'/cw1'}>Ćwiczenie 1</Link>
        </li>
    </ul>
  )
}

export default Nav