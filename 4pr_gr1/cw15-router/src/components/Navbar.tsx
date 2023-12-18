import React from 'react'
import { Link } from 'react-router-dom'

type Props = {}

const Navbar = (props: Props) => {
  return (
    <div>
        <h3>MENU</h3>
        <ul className='list-group'>
            <li className='list-group-item nav-item bg-light'>
                <Link className='w-100 nav-link' to='/'>Strona główna</Link>
            </li>
            <li className='list-group-item nav-item bg-light'>
                <Link className='nav-link' to='/page1'>Strona pierwsza</Link>
            </li>
            <li className='list-group-item nav-item bg-light'>
                <Link className='nav-link' to='/page2'>Strona druga</Link>
            </li>
        </ul>
    </div>
  )
}

export default Navbar