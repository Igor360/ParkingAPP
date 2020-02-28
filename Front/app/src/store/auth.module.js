import JwtService from "../services/jwt.service";
import {CHECK_AUTH, LOGIN, LOGOUT, REGISTER} from "./actions.type";
import ApiService from "../services/api.service";
import {API_SLUG} from "../config";
import {PURGE_AUTH, SET_AUTH, SET_ERROR} from "./mutations.type";

const state = {
    errors: null,
    user: {},
    isAuth: !!JwtService.getToken()
};

const getters = {
    currentUser(state) {
        return state.user;
    },
    isAuth(state) {
        return state.isAuth;
    }
};

const actions = {
    [LOGIN](context, credentials) {
        return new Promise(resolve => {
            ApiService.post('/login', API_SLUG, {user: credentials}).then(({data}) => {
                context.commit(SET_AUTH, data.user);
                resolve(data);
            });
        });
    },
    [LOGOUT](context) {
        context.commit(PURGE_AUTH)
    },
    [REGISTER](context, credentials) {
        return new Promise(resolve => {
            ApiService.post('/register', API_SLUG, {user: credentials}).then(({data}) => {
                context.commit(SET_AUTH, data.user);
                resolve(data);
            }).catch(({response}) => {
                context.commit(SET_ERROR, response.data.errors);
            });
        });
    },
    [CHECK_AUTH](context) {
        if (JwtService.getToken()) {
            ApiService.setHeader();
            ApiService.get("/user", API_SLUG).then(({data}) => {
                context.commit(SET_AUTH, data.user);
            }).catch(({response}) => {
                context.commit(SET_ERROR, response.data.errors);
            });
        } else {
            context.commit(PURGE_AUTH);
        }
    }
};

const mutations = {
    [SET_ERROR](state, error) {
        state.errors = error;
    },
    [SET_AUTH](state, user) {
        state.user = user;
        state.isAuth = true;
        state.errors = {};
        JwtService.saveToken(state.user.token);
    },
    [PURGE_AUTH](state) {
        state.isAuth = false;
        state.user = {};
        state.errors = {};
        JwtService.destroyToken();
    }
};

export default {
    state,
    actions,
    mutations,
    getters
};