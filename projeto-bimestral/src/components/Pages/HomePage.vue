<template>
<HeaderComp></HeaderComp>
<CarrosselComp></CarrosselComp>
</template>

<script>
import CarrosselComp from '../CarrosselComp.vue';
import HeaderComp from '../HeaderComp.vue';

export default {
    name: "HomePage",
    components: {CarrosselComp, HeaderComp}
}
</script>

<style>

</style>