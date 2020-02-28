<template>
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <agile :options="myOptions">
            <div class="slide">
                <img class="bd-placeholder-img" width="100%" height="900" src="../../assets/images/cars/underground-parking.jpg"/>
                <div class="container">
                    <div class="text-bg-gradient "></div>
                    <div class="carousel-caption text-left">
                        <h1>Best parking places for your car</h1>
                        <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                        <p><a class="btn btn-lg btn-warning" href="#" role="button">Sign up today</a></p>
                    </div>
                </div>
            </div>
            <div class="slide">
                <img class="bd-placeholder-img" width="100%" height="900"
                     src="../../assets/images/cars/maxresdefault.jpg"/>
                <div class="container">
                    <div class="text-bg-gradient "></div>
                    <div class="carousel-caption">
                        <h1>Real time parking status</h1>
                        <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                        <p><a class="btn btn-lg btn-warning" href="#" role="button">Learn more</a></p>
                    </div>
                </div>
            </div>
            <div class="slide">
                    <img class="bd-placeholder-img" width="100%" height="900" src="../../assets/images/cars/CitiesNEW_LargeFeature_1536x1152.jpg"/>
                    <div class="container">
                        <div class="text-bg-gradient "></div>
                        <div class="carousel-caption text-right">
                            <h1>Add your own parking company</h1>
                            <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta
                                gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                            <p><a class="btn btn-lg btn-warning" href="#" role="button">Browse gallery</a></p>
                        </div>
                    </div>
            </div>
        </agile>
    </div>
</template>

<script>
    import {VueAgile} from 'vue-agile'
    export default {
        name: "Carousel",
        components: {
            agile: VueAgile
        },
        data() {
            return {
                myOptions: {
                    navButtons: false,
                    dots: false,
                    fade: true,
                    autoplay: true,
                    autoplaySpeed: 3000 
                }
            };
        }
    }
</script>

<style>
    #myCarousel {
        padding-bottom: 50px;
    }

    .text-bg-gradient {
        display: block;
        position: absolute;
        background-image: -webkit-gradient(linear, left top, left bottom, from(rgba(255,255,255,0)), color-stop(40%, rgba(0,0,0,0.5)), to(rgba(0,0,0,0.6)));
        background-image: linear-gradient(to bottom, rgba(255,255,255,0) 0%, rgba(0,0,0,0.5) 40%, rgba(0,0,0,0.6) 100%);
        top: 30%;
        bottom: 0;
        left: 0;
        right: 0;
        z-index: 2;
    }
</style>