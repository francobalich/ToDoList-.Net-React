import { Todo, Title, Browser } from "./"

export const TodoList = ({title}) => {
  return (
    <>
    <Title title={title}/>
      <div className="TodoContainer">
        <Browser />
        <Todo />
        <Todo />
        <Todo />
        <Todo />
      </div>
    </>
  )
}
