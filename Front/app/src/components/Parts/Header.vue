<template>
    <header>
        <nav class="navbar navbar-expand-md navbar-light fixed-top bg-light">
            <div class="container">
                <router-link class="navbar-brand font-weight-bold" :to="{ path : '/'}">Parking <span
                        class="text-warning">Now</span></router-link>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarCollapse"
                        aria-controls="navbarCollapse" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarCollapse">
                    <ul class="navbar-nav mr-auto">

                        <router-link
                                to="/#"
                                v-slot="{ href, isActive }"
                        >
                            <li :class="['nav-item', isActive && 'active']" >
                                <a class="nav-link" :href="href">Home <span class="sr-only">(current)</span></a>
                            </li>
                        </router-link>


                        <router-link
                                to="/companies"
                                v-slot="{ href, isActive }"
                        >
                            <li :class="['nav-item', isActive && 'active']" >
                                <a class="nav-link" :href="href">Companies <span class="sr-only">(current)</span></a>
                            </li>
                        </router-link>

                        <router-link
                                to="/parking_places"
                                v-slot="{ href, isActive }"
                        >
                            <li :class="['nav-item', isActive && 'active']" >
                                <a class="nav-link" :href="href">Parkings places <span class="sr-only">(current)</span></a>
                            </li>
                        </router-link>
                    </ul>
                    <form class="form-inline mt-2 mt-md-0">
                        <input class="form-control mr-sm-2" type="text" placeholder="Search place" aria-label="Search">
                        <button class="btn btn-outline-warning my-2 my-sm-0" type="submit">Search</button>
                    </form>
                    <router-link class="btn btn-outline-dark m-1" :to="{ path: '/login' }">Login</router-link>
                </div>
            </div>
        </nav>
    </header>
</template>

<script>
    export default {
        name: "Header"
    }
</script>

<style scoped>
    .navbar .form-inline .form-control {
        background: transparent;
        color: #495057;
        background-color: #dee2e6;
        background-clip: padding-box;
        border: none;
    }
    
    .navbar-light .navbar-nav .active > .nav-link, .navbar-light .navbar-nav .nav-link.active, .navbar-light .navbar-nav .nav-link.show, .navbar-light .navbar-nav .show > .nav-link {
        color: rgba(0, 0, 0, .9);
        border-bottom: 1px solid;
    }
</style>