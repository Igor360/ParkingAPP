import Vue from 'vue';
import router from './router';
import store from './store';
import App from './App.vue';
import ApiService from "./services/api.service";
import {CHECK_AUTH} from "./store/actions.type";
import Notifications from 'vue-notification'

Vue.config.productionTip = false;
Vue.use(Notifications);
ApiService.init();

router.beforeEach((to, from, next) => {
    const nearestWithTitle = to.matched.slice().reverse().find(r => r.meta && r.meta.title);

    if (nearestWithTitle) document.title = nearestWithTitle.meta.title;

    if (to.matched.some(record => record.meta.requiresAuth)) {
        next();
        Promise.all([store.dispatch(CHECK_AUTH)]).then(() => {
            if (store.state.isAuth) {
                next();
            } else {
                next({
                    path: '/login',
                    params: {nextUrl: to.fullPath}
                });
            }
        });

    } else if (to.matched.some(record => record.meta.guest)) {
        Promise.all([store.dispatch(CHECK_AUTH)]).then(() => {
            if (store.state.isAuth) {
                next({
                    path: '/user/profile',
                    params: {nextUrl: to.fullPath}
                });
            } else {
                next();
            }
        });
    } else {
        next();
    }
});

new Vue({
    router,
    store,
    render: h => h(App),
}).$mount('#app');
