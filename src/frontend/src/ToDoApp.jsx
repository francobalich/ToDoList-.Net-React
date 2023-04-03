import { toDoApi } from '../api'
import './App.css'
import { BrowserRouter } from "react-router-dom"
import { AppRouter } from './router/AppRouter'

function ToDoApp() {
  const testApi = async ()=>{
     let resp = await toDoApi.get()
     console.log(resp.data);
     return
  }
  return (
    <BrowserRouter>
      <AppRouter />
    </BrowserRouter>
  )
}

export default ToDoApp
