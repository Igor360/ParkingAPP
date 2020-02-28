import Vue from "vue";
import VueRouter from "vue-router";
import {USER_TYPE} from "../config";

Vue.use(VueRouter);

export default new VueRouter({
    routes: [
        {
            path: "/",
            component: () => import("@/components/Home/Index"),
            meta: {
                guest: true
            }
        },
        {
            path: "/login",
            component: () => import("@/components/Auth/Login/Index"),
            meta: {
                guest: true
            }
        },
        {
            path: "/register",
            component: () => import("@/components/Auth/Registration/Index"),
            meta: {
                guest: true
            }
        },
        {
            path: "/companies",
            component: () => import("@/components/Companies/Index"),
            meta: {
                guest: true
            }
        },
        {
            path: "/parking_places",
            component: () => import("@/components/ParkingPlaces/Index"),
            meta: {
                guest: true
            }
        },
        {
            path: "/user/profile",
            component: () => import("@/components/User/Profile/Index"),
            meta: {
                requiresAuth: true,
                type: USER_TYPE,
            }
        }

    ]
});