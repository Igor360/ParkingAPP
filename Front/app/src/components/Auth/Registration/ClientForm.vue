<template>
    <div class="form">
        <h1 class="h3 mb-3 font-weight-bold">Please sign up client</h1>
        <div class="row p-3">
            <label for="inputEmail" class="sr-only">Email address</label>
            <input type="email" id="inputEmail" class="form-control" placeholder="Email address" required=""
                   autofocus="">
        </div>
        <div class="row p-3">
            <label for="inputPassword" class="sr-only">Password</label>
            <input type="password" id="inputPassword" class="form-control" placeholder="Password" required="">
        </div>
        <div class="row p-3">
            <label for="inputPassword" class="sr-only">Password confirmation</label>
            <input type="password" id="confirmPassword" class="form-control" placeholder="Password confirmation" required="">
        </div>
        <div class="row p-3">
            <label for="inputPassword" class="sr-only">First Name</label>
            <input type="text" id="firstName" class="form-control" placeholder="First Name" required="">
        </div>
        <div class="row p-3">
            <label for="inputPassword" class="sr-only">Last Name</label>
            <input type="text" id="lastName" class="form-control" placeholder="Last Name" required="">
        </div>
    </div>
</template>

<script>
    export default {
        name: "ClientForm",
        data () {
            return {
                
            }
        }
    }
</script>

<style scoped>

</style>