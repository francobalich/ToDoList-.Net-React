import '../styles/Todo.css'
import deleteBtn from '../assets/delete.svg'
export const Todo = () => {
  return (
    <div className="todoItem">

      <img src={deleteBtn} alt='Delete button' ></img>

      <input type='checkbox' className='checkbox' />
      <div className="todo_info">
        <p className="todo_title">Tarea N°1</p>
        <p className="todo_time">12:42 PM</p>
        <p className="todo_description">Lorem ipsum dolor sit amet, consectetur adipiscing elit</p>
      </div>
    </div>
  )
}
