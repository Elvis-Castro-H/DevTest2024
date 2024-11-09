import axios from "axios"

const BASE_URL = "http://localhost:5251"

const apiClient = axios.create({
    baseURL: BASE_URL
});

export default apiClient;