import '../styles/Browser.css'

export const Browser = () => {
  return (
    <div className="browser">
      <input className="browser__input" type="text" placeholder="Ingrese el nombre de la tarea"/>
      <input className="browser__btn" type="button" value="Buscar" />
    </div>
  )
}
