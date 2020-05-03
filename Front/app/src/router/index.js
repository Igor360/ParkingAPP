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
                title : 'Home',
                guest: true
            }
        },
        {
            path: "/login",
            component: () => import("@/components/Auth/Login/Index"),   
            meta: {
                title : 'Login',
                guest: true
            }
        },
        {
            path: "/register",
            component: () => import("@/components/Auth/Registration/Index"),
            meta: {
                title : 'Register',
                guest: true
            }
        },
        {
            path: "/companies",
            component: () => import("@/components/Companies/Index"),
            meta: {
                title: 'Companies',
                guest: true
            }
        },
        {
            path: "/parking_places",
            component: () => import("@/components/ParkingPlaces/Index"),
            meta: {
                title: "Parking Places",
                guest: true
            }
        },
        {
            path: "/terms",
            component: () => import("@/components/Terms/Index"),
            meta: {
                title: "Terms",
                guest: true
            }
        },
        {
            path: "/policy",
            component: () => import("@/components/Policy/Index"),
            meta: {
                title : "Policy",
                guest: true
            }
        },
        {
            path: "/user/profile",
            component: () => import("@/components/User/Profile/Index"),
            meta: {
                title: "Profile",
                requiresAuth: true,
                type: USER_TYPE,
            }
        }

    ]
});