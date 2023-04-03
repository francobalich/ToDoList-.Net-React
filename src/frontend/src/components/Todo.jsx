import '../styles/Todo.css'
import deleteBtn from '../assets/delete.svg'
export const Todo = ({id,name,state, description,date}) => {
  return (
    <div className="todoItem">

      <img src={deleteBtn} alt='Delete button' ></img>

      <input type='checkbox' className='checkbox' />
      <div className="todo_info">
        <p className="todo_title">{name}</p>
        <p className="todo_time">{date}</p>
        <p className="todo_description">{description}</p>
      </div>
    </div>
  )
}
