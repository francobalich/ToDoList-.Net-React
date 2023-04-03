import { useNavigate } from 'react-router-dom'
import '../App.css'
import { Title } from '../components'
import { useForm } from '../hooks/useForm'
import { toDoApi } from '../../api'

const todoFormFields = {
  todoName:'',
  todoDescription:'',
  todoDate:''
}

export const NewTodo = () => {
  const navigate = useNavigate()
  const {todoName, todoDescription,todoDate, onInputChange:onTodoInputChange}=useForm(todoFormFields)

  const cancelOnClick=()=>{
    navigate('/', { replace: true })
  }
  const acceptOnClick=async(event)=>{
    event.preventDefault()
    let data = {
      name:todoName,
      description:todoDescription,
      date:todoDate,
      state:true
    }
    let resp = await toDoApi.post('/',data)
    navigate('/', { replace: true })
  }
  return (
    <div className="App">
      <Title title="Nueva tarea"/>
      <form onSubmit={acceptOnClick} className='newTodoForm'>
      <div className='inputContainer'>
        <input
            className="browser__input"
            type="text"
            name='todoName'
            value={todoName}
            onChange={onTodoInputChange}
            placeholder="Titulo de la tarea"/>
          <input
            className="browser__input"
            type="text"
            name='todoDescription'
            value={todoDescription}
            onChange={onTodoInputChange}
            placeholder="Descripción de la tarea"/>
          <input
            className="browser__input"
            type="date"
            min="2023-04-03"
            name='todoDate'
            value={todoDate}
            onChange={onTodoInputChange}
            placeholder="Fecha de la tarea"/>
        </div>
        <div className='buttonContainer'>
          <input className="cancel__btn" type="button" value="Cancelar" onClick={cancelOnClick} />
          <input className="browser__btn" type="submit" value="Crear"/>
        </div>
      </form>
    </div>
  )
}
