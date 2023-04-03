import { Todo, Title } from "./"

export const TodoList = ({title}) => {
  return (
    <>
    <Title title={title}/>
      <div className="TodoContainer">
        <Todo />
        <Todo />
        <Todo />
        <Todo />
      </div>
    </>
  )
}
