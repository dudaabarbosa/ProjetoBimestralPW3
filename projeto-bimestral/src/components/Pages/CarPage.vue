<template>
<HeaderComp></HeaderComp>
<CarComp></CarComp>
<FooterComp></FooterComp>
</template>

<script>
import CarComp from '../CarComp.vue';
import FooterComp from '../FooterComp.vue';
import HeaderComp from '../HeaderComp.vue';

export default {
    name: "CarPage",
    components: {HeaderComp, CarComp, FooterComp}
}
</script>

<style scoped>
footer{
    position: relative;
    top: 100%;
}
</style>