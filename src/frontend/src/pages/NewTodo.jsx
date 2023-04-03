import { useNavigate } from 'react-router-dom'
import '../App.css'
import { Title } from '../components'
import { useForm } from '../hooks/useForm'

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
  const acceptOnClick=(event)=>{
    event.preventDefault()
    let data = {
      name:todoName,
      description:todoDescription,
      date:todoDate
    }
    console.log(data);
    //navigate('/', { replace: true })
    //todo: Agregar crear todo
  }
  const getToDosApi = async ()=>{
    let data = {
      "name": name,
      "description": "string",
      "state": true
    }
    let resp = await toDoApi.post()
    return resp.data
 }
  return (
    <div className="App">
      <Title title="Nueva tarea"/>
      <form onSubmit={acceptOnClick}>
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
            placeholder="Descripcion de la tarea"/>
          <input
            className="browser__input"
            type="text"
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
