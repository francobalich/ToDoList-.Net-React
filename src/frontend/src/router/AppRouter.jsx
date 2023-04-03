import { Navigate, Route, Routes } from "react-router-dom"
import { Home,NewTodo } from "../pages"

export const AppRouter = () => {
  return (
    <Routes>
      <Route path="/" element={<Home />} />
      <Route path="/new" element={<NewTodo />} />
      <Route path='*' element={<Navigate to= '/' />} />
    </Routes>
  )
}
