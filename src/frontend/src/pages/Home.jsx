import {TodoList, AddButton} from '../components'

export const Home = () => {
  return (
    <>
     <div className="App">
        <TodoList title="Tareas de hoy" />
      </div>
      <AddButton />
    </>
  )
}
