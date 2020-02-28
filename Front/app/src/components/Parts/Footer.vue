<template>
    <footer class="container footer">
        <p class="float-right"><a href="#">Back to top</a></p>
        <p>© 2017-2019 Parking <a href="#">Privacy</a> · <a href="#">Terms</a></p>
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
        border-top: 1px dashed #ddd;   
    }
    .footer a {
        color: #ddd;
        text-decoration: none;
        background-color: transparent;
    }
</style>