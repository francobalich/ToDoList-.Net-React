import '../styles/Todo.css'
import deleteBtn from '../assets/delete.svg'
import { toDoApi } from '../../api'

export const Todo = ({id,name,state, description,date}) => {

  const deleteOnClick = async()=>{
    await toDoApi.delete(`/${id}`)
  }
  return (
    <div className="todoItem">

      <img src={deleteBtn} alt='Delete button' onClick={deleteOnClick}></img>

      <input type='checkbox' className='checkbox' />
      <div className="todo_info">
        <p className="todo_title">{name}</p>
        <p className="todo_time">{`${date.substring(0,10)}`}</p>
        <p className="todo_description">{description}</p>
      </div>
    </div>
  )
}
