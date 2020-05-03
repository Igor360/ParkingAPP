<template>
    <main v-if="!isAuth && this.$route.meta.guest" role="main">
        <Header/>
        <notifications group="main" position="top left"/>
        <router-view></router-view>
        <Footer/>
    </main>
    <main v-else-if="this.$route.meta.requiresAuth">
        <AuthHeader/>
        <notifications group="main" position="top left" />
        <router-view></router-view>
    </main>
    <main v-else>
        <NotFound/>
    </main>
</template>

<script>
    import Header from "./Parts/Header";
    import AuthHeader from "./Parts/Auth/Header";
    import Footer from './Parts/Footer';
    import {mapGetters} from "vuex";
    import NotFound from "../views/404";

    export default {
        name: "Index",
        components: {NotFound, Footer, Header, AuthHeader},
        computed: {...mapGetters(['isAuth'])},
    }
</script>

<style>
    .content {
        margin-top: 80px;
    }
</style>