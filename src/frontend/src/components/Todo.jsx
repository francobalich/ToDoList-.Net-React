import '../styles/Todo.css'

export const Todo = () => {
  return (
    <div className="todoItem">
      <input type='checkbox' />
      <div className="todo_info">
        <p className="todo_name">Lorem ipsum dolor sit amet, consectetur adipiscing elit</p>
        <p className="todo_time">12:42 PM</p>
      </div>
    </div>
  )
}
