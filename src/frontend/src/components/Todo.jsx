import '../styles/Todo.css'
import deleteBtn from '../assets/delete.svg'
import { toDoApi } from '../../api'
import { useState } from 'react';

export const Todo = ({id,name,state, description,date}) => {
  const [checked, setChecked] = useState(state);
  const deleteOnClick = async()=>{
   await toDoApi.delete(`/${id}`)
  }
  const completeOnClick = async()=>{
    setChecked(!checked);
    let todo = {
      id,
      name,
      date,
      description,
      state: !checked
    }
    let resp=await toDoApi.put(`/`,todo)
    //console.log(resp);
  }
  return (
    <div className="todoItem">

      <img src={deleteBtn} alt='Delete button' onClick={deleteOnClick}></img>

      <input type='checkbox' className='checkbox' checked={!state} onChange={completeOnClick}/>
      <div className="todo_info">
        <p className={`todo_title ${!checked?"complete":""}`}>{name}</p>
        <p className={`todo_time ${!checked?"complete":""}`}>{`${date.substring(0,10)}`}</p>
        <p className={`todo_description ${!checked?"complete":""}`}>{description}</p>
      </div>
    </div>
  )
}
