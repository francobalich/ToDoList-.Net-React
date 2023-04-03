import { toDoApi } from '../api'
import './App.css'

function App() {
  const testApi = async ()=>{
     let resp = await toDoApi.get()
     console.log(resp.data);
     return
  }
  return (
    <div className="App">
        <button onClick={testApi}>
          haceme clic
        </button>
    </div>
  )
}

export default App
