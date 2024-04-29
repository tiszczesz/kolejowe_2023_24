import React, { useContext } from 'react'
import TodosContext from '../contexts/todosContext';

type Props = {}

const Info = (props: Props) => {
    const context = useContext(TodosContext);
  return (
    <div className='bg-warning fs-6 text-center'>
        Ilość zadań do wykonania: {context?.todos.length}
    </div>
  )
}

export default Info