<template>
    <div class="content">
        <div class="container login">
            <form class="form-signin" @submit.prevent="onSubmit(email, password)">
                <h1 class="h2 mb-2 font-weight-normal">Please sign in</h1>
                <ul v-if="errors" class="error-messages">
                    <li v-for="(v, k) in errors" :key="k">{{ k }} {{ v | error }}</li>
                </ul>
                <div class="row p-3">
                    <label for="inputEmail" class="sr-only">Email address</label>
                    <input type="email" id="inputEmail" class="form-control" placeholder="Email address" required="" v-model="email"
                           autofocus="">
                </div>
                <div class="row p-3">
                    <label for="inputPassword" class="sr-only">Password</label>
                    <input type="password" id="inputPassword" class="form-control" placeholder="Password" required="" v-model="password">
                </div>
                <div class="checkbox mb-3">
                    <label>
                        <input type="checkbox" value="remember-me"> Remember me
                    </label>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <router-link class="btn btn-lg btn-outline-info btn-block" :to="{ path : '/register' }">Sign up</router-link>
                    </div>
                    <div class="col-md-6">
                        <button class="btn btn-lg btn-outline-warning btn-block" type="submit">Sign in</button>
                    </div>
                </div>
            </form>
        </div>
    </div>
</template>

<script>
    import {mapState} from "vuex";

    export default {
        name: "Login",
        data()  {
            return {
                email : '',
                password : ''
            };
        },
        methods : {
            onSubmit() {
                this.$router.push({
                    path : "/user/profile"
                });
            } 
        },
        computed: {
            ...mapState({
                errors : state => state.auth.errors
            })
        }
    }
</script>

<style scoped>
</style>