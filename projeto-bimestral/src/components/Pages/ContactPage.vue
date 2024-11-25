<template>
<HeaderComp></HeaderComp>
<ContactComp></ContactComp>
<FooterComp></FooterComp>
</template>

<script>
import ContactComp from '../ContactComp.vue';
import FooterComp from '../FooterComp.vue';
import HeaderComp from '../HeaderComp.vue';

export default {
    name: "ContactPage",
    components: {ContactComp, HeaderComp, FooterComp}
}
</script>

<style>
footer{
    position: relative;
}
</style>