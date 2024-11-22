<template>
<div class="fundo">
<CadastroComp></CadastroComp>
</div>
</template>

<script>
import CadastroComp from '../CadastroComp.vue';

export default {
    name: "CadastroPage",
    components: {
    CadastroComp
    }
}
</script>

<style>
.fundo{
background-color: #9a70f0;
height: 1200px;
padding-top: 100px;
}
</style>