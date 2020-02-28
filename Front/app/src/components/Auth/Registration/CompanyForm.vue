<template>
    <div class="form">
        <h1 class="h3 mb-3 font-weight-normal">Please sign up company</h1>
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
            <input type="password" id="confirmPassword" class="form-control" placeholder="Password" required="">
        </div>
        <div class="row p-3">
            <label for="inputPassword" class="sr-only">First Name</label>
            <input type="text" id="firstName" class="form-control" placeholder="First Name" required="">
        </div>
        <div class="row p-3">
            <label for="inputPassword" class="sr-only">Last Name</label>
            <input type="text" id="lastName" class="form-control" placeholder="Last Name" required="">
        </div>
        <div class="row p-3">
            <label for="inputPassword" class="sr-only">Company Name</label>
            <input type="text" id="companyName" class="form-control" placeholder="Company Name" required="">
        </div>
        <div class="row p-3">
            <label for="inputPassword" class="sr-only">Company Site</label>
            <input type="text" id="companySite" class="form-control" placeholder="Company Site" required="">
        </div>
        <div class="row p-3">
            <label for="inputPassword" class="sr-only">Company Address</label>
            <input type="text" id="companyAddress" class="form-control" placeholder="Company Site" required="">
        </div>
    </div>
</template>

<script>
    export default {
        name: "CompanyForm"
    }
</script>

<style scoped>

</style>