<template>
    <Index/>
</template>

<script>
    import Index from "./components/Index";
    import 'bootstrap/dist/css/bootstrap.min.css';

    export default {
        title: 'App',
        name: 'App',
        components:
            {
                Index
            }
    }

</script>

<style>
    @import url('https://fonts.googleapis.com/css?family=Nunito&display=swap');
    @import url('https://fonts.googleapis.com/css?family=PT+Sans&display=swap');
    body {
        font-family: 'PT Sans' ;
    }
</style>
