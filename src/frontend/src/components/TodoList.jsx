import { Todo, Title, Browser } from "./"
import '../App.css'
import { useEffect, useState } from "react"
import { toDoApi } from "../../api"

export const TodoList = ({title}) => {
  const [todos, setTodos] = useState([])
  const getToDosApi = async ()=>{
    let resp = await toDoApi.get()
    return resp.data
 }
 useEffect(() => {
  getToDosApi().then((resp)=>{
    setTodos(resp)
  })
 }, [todos])
  return (
    <>
    <Title title={title}/>
      <div className="TodoContainer">
        {
          todos.map((todo)=>{
            return<Todo key={todo.id} {...todo} />
          })
        }
      </div>
    </>
  )
}
