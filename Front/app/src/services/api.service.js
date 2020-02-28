import {API_URL} from "../config";
import VueAxios from "vue-axios";
import Axios from "axios";
import Vue from "vue";
import JwtService from "./jwt.service";


const ApiService = {
    init() {
        Vue.use(VueAxios, Axios);
        Vue.axios.defaults.baseURL = API_URL;
    },
    setHeader() {
        Vue.axios.defaults.headers.common["Authorization"] = `Bearer ${JwtService.getToken()}`;
    },
    query(resource, params) {
        return Vue.axios.get(resource, params).catch(error => {
            throw  new Error(`Api service error: ${error}`);
        });
    },
    get(resource, slug = "") {
        return Vue.axios.get(`${resource}/${slug}`).catch(error => {
            throw new Error(`Api service error: ${error}`);
        });
    },
    post(resource, slug = "", param) {
        return Vue.axios.post(`${resource}/${slug}`, param);
    },
    update(resource, slug = "", param) {
        return Vue.axios.put(`${resource}/${slug}`, param);
    },
    put(resource, slug = "", param) {
        return Vue.axios.put(`${resource}/${slug}`, param);
    },
    delete(resource, slug = "") {
     return Vue.axios.delete(`${resource}/${slug}`).catch(error => {
         throw new Error(`Api service error : ${error}`);
     });
    }
};

export default ApiService;