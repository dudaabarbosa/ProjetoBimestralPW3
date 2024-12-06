import axios from "axios"

const api = axios.create({
    baseURL: 'https://localhost:7196/api',
})

export default api;