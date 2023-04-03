import axios from 'axios'
import { getEnvVariables } from '../helper/getEnvVariables'
const {VITE_API_URL} = getEnvVariables()

const toDoApi = axios.create({
    baseURL:VITE_API_URL
})

export default toDoApi