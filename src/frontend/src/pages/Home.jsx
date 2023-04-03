import {TodoList, AddButton} from '../components'

export const Home = () => {
  return (
    <>
     <div className="App">
        <TodoList title="Lista de tareas" />
      </div>
      <AddButton />
    </>
  )
}
