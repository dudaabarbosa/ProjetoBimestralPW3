<template>
<HeaderComp></HeaderComp>
<SobreNos></SobreNos>
<FooterComp></FooterComp>
</template>

<script>
import FooterComp from '../FooterComp.vue';
import HeaderComp from '../HeaderComp.vue';
import SobreNos from '../SobreNos.vue';

export default {
    name: "AboutPage",
    components: {HeaderComp, SobreNos, FooterComp}
}
</script>

<style scoped>
footer{
    position: absolute;
    bottom: 0;
}
header{
    margin-bottom: 20px;
}
</style>