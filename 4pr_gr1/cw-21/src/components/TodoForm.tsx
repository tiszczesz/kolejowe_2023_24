import React, { useContext } from "react";
import { useForm, SubmitHandler } from "react-hook-form";
import { Todo } from "../Data/TodosData";
import TodosContext from "../contexts/todosContext";
import { v4 as uuidv4 } from "uuid";

type Props = {};
type Inputs = {
  todoInsert: Todo;
};
const TodoForm = (props: Props) => {
  const context = useContext(TodosContext);
  const {
    register,
    handleSubmit,
    watch,
    formState: { errors },
    reset
  } = useForm<Inputs>();
  const onSubmit: SubmitHandler<Inputs> = (data) => {
    data.todoInsert.id = uuidv4();
    const date = new Date(data.todoInsert.date);
    data.todoInsert.date = date;
    context?.handleInsert({ ...data.todoInsert });
    reset();
    // data.todoInsert.title = "";
    // data.todoInsert.content = "";
    // data.todoInsert.date = new Date();
  };

  console.log(watch("todoInsert.title")); // watch input value by passing the name of it
  return (
    /* "handleSubmit" will validate your inputs before invoking "onSubmit" */
    <form onSubmit={handleSubmit(onSubmit)}>
      {/* register your input into the hook by invoking the "register" function */}
      <div className="row m-3">
        <input
          className="col-3"
          defaultValue=""
          {...register("todoInsert.title", { required: "podaj tytuł" })}
          placeholder="podaj nazwę"
        />
        {errors?.todoInsert?.title && (
          <span className="col-3 text-danger">
            {errors.todoInsert.title.message}
          </span>
        )}
      </div>

      <div className="row m-3">
        <input
          className="col-3"
          defaultValue=""
          {...register("todoInsert.content", { required: "podaj zawartość" })}
          placeholder="podaj treść"
        />
        {errors?.todoInsert?.content && (
          <span className="col-3 text-danger">
            {errors.todoInsert.content.message}
          </span>
        )}
      </div>
      <div className="row m-3">
        <input
          className="col-3"
          type="date"
          {...register("todoInsert.date", { required: "podaj datę" })}
        />

        {errors.todoInsert?.date && (
          <span className="col-3 text-danger">Podaj porawną datę</span>
        )}
      </div>

      <input className="btn btn-secondary m-2" type="submit" />
    </form>
  );
};

export default TodoForm;
