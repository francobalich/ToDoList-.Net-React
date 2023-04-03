import { toDoApi } from '../api'
import './App.css'
import {TodoList, AddButton} from './components'

function App() {
  const testApi = async ()=>{
     let resp = await toDoApi.get()
     console.log(resp.data);
     return
  }
  return (
    <>
      <div className="App">
        <TodoList title="Tareas de hoy" />
      </div>
      <AddButton />
    </>
  )
}

export default App
