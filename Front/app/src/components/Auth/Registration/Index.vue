<template>
    <div class="content">
        <div class="container login">
            <form class="form-signin">
                <div class="row">
                    <div class="col-md-6">
                        <button :class="['btn btn-lg btn-block', selected === 'ClientForm' ? 'btn-dark' : 'btn-light']" @click="selected='ClientForm'">
                            Customer</button>
                    </div>
                    <div class="col-md-6">
                        <button :class="['btn btn-lg btn-block', selected === 'CompanyForm' ? 'btn-dark' : 'btn-light']" @click="selected='CompanyForm'">
                            Company
                        </button>
                    </div>
                </div>
                <component :is="selected"></component>
                <div class="checkbox mb-3">
                    <label>
                        <input type="checkbox" value="accept-terms"> Accept terms of use
                    </label>
                </div>
                <button class="btn btn-lg btn-outline-warning btn-block" type="submit">Sign in</button>
            </form>
        </div>
    </div>
</template>

<script>
    import ClientForm from "./ClientForm";
    import CompanyForm from "./CompanyForm";

    export default {
        name: "Registration",
        components: {ClientForm, CompanyForm},
        data() {
            return {
                tabs: ["ClientForm", "CompanyForm"],
                selected:
                    'ClientForm'
            }
        }
    }
</script>

<style scoped>
</style>