<template>
<HeaderComp></HeaderComp>
<CarrosselComp></CarrosselComp>
<FooterComp></FooterComp>
<div class="books">
<BooksComp></BooksComp>
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
    position: absolute;
    margin-top: 800px;
}
.books{
    margin-top: 50px;
}
</style>