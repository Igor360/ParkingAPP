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
                <div class="custom-control custom-checkbox pb-3">
                    <input type="checkbox" class="custom-control-input" value="accept-terms"  id = "same-address"/>
                    <label class="custom-control-label" for="same-address"> Accept terms of use</label>
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
    .form {
        margin-top: 1em;
    }
</style>