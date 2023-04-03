import '../App.css'
import { Title } from '../components'

export const NewTodo = () => {
  return (
    <div className="App">
      <Title title="Nueva tarea"/>
      <div className='inputContainer'>
        <input className="browser__input" type="text" placeholder="Titulo de la tarea"/>
        <input className="browser__input" type="text" placeholder="Nombre de la tarea"/>
        <input className="browser__input" type="text" placeholder="Fecha de la tarea"/>
      </div>
      <div className='buttonContainer'>
        <input className="cancel__btn" type="button" value="Cancelar" />
        <input className="browser__btn" type="button" value="Crear" />
      </div>
    </div>
  )
}
