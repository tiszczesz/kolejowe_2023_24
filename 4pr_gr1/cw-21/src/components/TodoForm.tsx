import React, { useContext } from 'react'
import { useForm, SubmitHandler } from "react-hook-form"
import { Todo } from '../Data/TodosData'
import TodosContext from '../contexts/todosContext'
import { v4 as uuidv4 } from 'uuid';

type Props = {}
type Inputs = {
   todoInsert:Todo
  }
const TodoForm = (props: Props) => {
    const context = useContext(TodosContext);
    const {
        register,
        handleSubmit,
        watch,
        formState: { errors },
      } = useForm<Inputs>()
      const onSubmit: SubmitHandler<Inputs> = (data) =>{
        data.todoInsert.id = uuidv4()
        context?.handleInsert({...data.todoInsert })
      }
    
      console.log(watch("todoInsert.title")) // watch input value by passing the name of it
  return (
        /* "handleSubmit" will validate your inputs before invoking "onSubmit" */
        <form onSubmit={handleSubmit(onSubmit)}>
        {/* register your input into the hook by invoking the "register" function */}
        <input defaultValue="" {...register("todoInsert.title")} placeholder='podaj nazwę' /><br />
        <input defaultValue="" {...register("todoInsert.content")} placeholder='podaj treść' /><br />
  
        {/* include validation with required or other standard HTML validation rules */}
        <input type='date' {...register("todoInsert.date", { required: true })} />
        {/* errors will return when field validation fails  */}
        {errors.todoInsert?.date && <span>This field is required</span>}
  
        <input type="submit" />
      </form>
  )
}

export default TodoForm


