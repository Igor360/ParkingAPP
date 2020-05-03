<template>
    <footer class="container footer">
        <p class="float-right"><a href="#">Back to top</a></p>
        <p>© 2017-2019 Parking <span class="now">Now</span> |    <router-link :to="{path: '/policy'}">Privacy</router-link> · <router-link :to="{path: '/terms'}">Terms</router-link></p>
    </footer>
</template>

<script>
    export default {
        name: "Footer"
    }
</script>

<style scoped>
    .footer {
        color: #ddd;
        margin-top: 50px;
        padding-top: 10px;
        border-top: 1px solid #ddd;   
    }
    .footer a {
        color: #ddd;
        text-decoration: none;
        background-color: transparent;
    }
    .footer .now {
        color: #fbeded;
    }
</style>