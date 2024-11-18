<template>
<HeaderComp></HeaderComp>
<ContactComp></ContactComp>
</template>

<script>
import ContactComp from '../ContactComp.vue';
import HeaderComp from '../HeaderComp.vue';

export default {
    name: "ContactPage",
    components: {ContactComp, HeaderComp}
}
</script>

<style>

</style>