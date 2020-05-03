<template>
    <div class="content">
        <div class="container login">
            <form class="form-signin" @submit.prevent="onSubmit(email, password)">
                <h1 class="h2 mb-2 font-weight-normal">Please sign in</h1>
                <ul v-if="Object.entries(errors).length !== 0 && errors.constructor === Object" class="alert alert-danger pl-5">
                    <li v-for="(v, k) in errors" :key="k">{{ k }} : {{ v | error }}</li>
                </ul>
                <div class="row p-3">
                    <label for="inputEmail" class="sr-only">Email address</label>
                    <input type="email" id="inputEmail" class="form-control" placeholder="Email address" required=""
                           v-model="email"
                           autofocus="">
                </div>
                <div class="row p-3">
                    <label for="inputPassword" class="sr-only">Password</label>
                    <input type="password" id="inputPassword" class="form-control" placeholder="Password" required=""
                           v-model="password">
                </div>
                <div class="custom-control custom-checkbox pb-3">
                    <input type="checkbox" class="custom-control-input" value="remember-me" id="same-address"/>
                    <label class="custom-control-label" for="same-address">Remember me</label>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <router-link class="btn btn-lg btn-outline-info btn-block" :to="{ path : '/register' }">Sign
                            up
                        </router-link>
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
    import {LOGIN} from "../../../store/actions.type";

    export default {
        name: "Login",
        data() {
            return {
                email: '',
                password: ''
            };
        },
        methods: {
            onSubmit(email, password) {
                this.$store.dispatch(LOGIN, {email, password}).then(() => this.$router.push({to: "/user/profile"})).catch(() => {
                    this.$notify({
                        group: 'main', text: 'Something went wrong, please try again later'
                    });
                    }
                );
            }
        },
        computed: {
            ...mapState({
                errors: state => state.auth.errors
            })
        }
    }
</script>

<style scoped>
</style>