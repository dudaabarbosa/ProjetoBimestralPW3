<template>
<HeaderComp></HeaderComp>
<CarrosselComp></CarrosselComp>
<div class="books">
<BooksComp></BooksComp>
<FooterComp></FooterComp>
</div>
</template>

<script>
import BooksComp from '../BooksComp.vue';
import CarrosselComp from '../CarrosselComp.vue';
import FooterComp from '../FooterComp.vue';
import HeaderComp from '../HeaderComp.vue';

export default {
    name: "HomePage",
    components: {CarrosselComp, HeaderComp, FooterComp, BooksComp}
}
</script>

<style scoped>
footer{
    position: relative;
    top: 100%;
}
.books{
    margin-top: 50px;
}
</style>