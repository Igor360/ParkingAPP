<template>
    <div class="container">
        <div class="row">
            <h3 class="font-weight-bold">Parkings</h3>
        </div>
        <nav class="navbar navbar-expand-lg navbar-light bg-light rounded mb-4 mt-1 shadow-sm">
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExample10" aria-controls="navbarsExample10" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse justify-content-md-center" id="navbarsExample10">

                <div class="col-md-5 mb-1 mt-1">
                    <select class="custom-select d-block w-100" id="country" required="">
                        <option value="">Choose Country...</option>
                        <option>United States</option>
                    </select>
                    <div class="invalid-feedback">
                        Please select a valid country.
                    </div>
                </div>
                <div class="col-md-4 mb-1 mt-1">
                    <select class="custom-select d-block w-100" id="state" required="">
                        <option value="">Choose State ...</option>
                        <option>California</option>
                    </select>
                    <div class="invalid-feedback">
                        Please provide a valid state.
                    </div>
                </div>
                <div class="col-md-3 mb-1 mt-1">
                    <input type="text" class="form-control" id="zip" placeholder="Min csc" required="">
                    <div class="invalid-feedback">
                        Zip code required.
                    </div>
                </div>
            </div>
        </nav>
        <div class="row mb-2">
            <div class="col-md-6">
                <div class="row no-gutters border rounded overflow-hidden flex-md-row mb-4 shadow-sm h-md-250 position-relative">
                    <div class="col p-4 d-flex flex-column position-static">
                        <strong class="d-inline-block mb-2 text-primary">Free</strong>
                        <h3 class="mb-0">Featured post</h3>
                        <div class="mb-1 text-muted">Nov 12</div>
                        <p class="card-text mb-auto">This is a wider card with supporting text below as a natural
                            lead-in to additional content.</p>
                        <a href="#" class="btn btn-outline-warning">Add</a>
                    </div>
                    <div class="col-auto d-none d-lg-block">
                        <img src="../../assets/images/map.jpg" class="bd-placeholder-img" width="200" height="250" />
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="row no-gutters border rounded overflow-hidden flex-md-row mb-4 shadow-sm h-md-250 position-relative">
                    <div class="col p-4 d-flex flex-column position-static">
                        <strong class="d-inline-block mb-2 text-success">0.5$ per hour</strong>
                        <h3 class="mb-0">Post title</h3>
                        <div class="mb-1 text-muted">Nov 11</div>
                        <p class="mb-auto">This is a wider card with supporting text below as a natural lead-in to
                            additional content.</p>
                        <a href="#" class="btn btn-outline-warning">Add</a>
                    </div>
                    <div class="col-auto d-none d-lg-block">
                        <img src="../../assets/images/map.jpg" class="bd-placeholder-img" width="200" height="250" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        name: "ParkingPlaces"
    }
</script>

<style scoped>
    .container {
        margin-top: 6em;
    }
</style>