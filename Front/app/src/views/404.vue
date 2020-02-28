<template>
    <main role="main" class="container">
        <div class="jumbotron bg-dark text-warning shadow-lg text-center">
            <h1 class="font-weight-bold">Page not found(((</h1>
            <p class="lead"><span class=""></span>..&#127795;.&#128663;...&#127795;</p>
            <router-link class="btn btn-lg btn-outline-warning" :to="{path: '/' }" role="button">Go home</router-link>
        </div>
    </main>
</template>

<script>
    export default {
        name: "NotFound"
    }
</script>

<style scoped>
    .container{
        margin-top: 6em;
    }
</style>