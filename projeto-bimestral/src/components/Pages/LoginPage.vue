<template>
<div class="login">
<LoginComp></LoginComp>
</div>
</template>

<script>
import LoginComp from '../LoginComp.vue';

export default {
    name: "LoginPage",
    components: {LoginComp}
}
</script>

<style scoped>
.login{
background-color: #9a70f0;
height: 1200px;
padding-top: 100px;
}
</style>