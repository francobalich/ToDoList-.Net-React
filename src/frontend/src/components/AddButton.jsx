import addBtn from  '../assets/addBtn.svg'
import '../styles/AddButton.css'
import { useNavigate } from 'react-router-dom'

export const AddButton = () => {
  const navigate = useNavigate()
  const addOnClick=()=>{
    navigate('/new', { replace: true })
  }
  return (
    <div className='addButton_container' onClick={addOnClick} >
      <img className='addButton' src={addBtn} alt='Icono de mas' />
    </div>
  )
}
