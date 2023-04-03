import addBtn from  '../assets/addBtn.svg'
import '../styles/AddButton.css'

export const AddButton = () => {
  return (
    <div className='addButton_container' >
      <img className='addButton' src={addBtn} alt='Icono de mas' />
    </div>
  )
}
