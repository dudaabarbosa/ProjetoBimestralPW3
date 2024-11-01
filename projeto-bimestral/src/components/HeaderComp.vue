<template>
<header>
    <div class="Barra">
    <img alt="logo" src="../assets/Logo.png">
    <form action="">
        <input type="text" placeholder="Pesquisar">
    </form>
    <v-icon name="bi-music-player"/>
    <p>Login</p>
    <p>Carrinho</p>
    </div>

    <nav>
        <router-link to="/home">Home</router-link>
        <router-link to="/sobre">Sobre nós</router-link>
        <router-link to="/login">Contato</router-link>
    </nav>
</header>
</template>

<script>
import OhVueIcon from "oh-vue-icons";
export default {
    name: "HeaderComp",
    components: {
        "v-icon": OhVueIcon
    }
}
</script>

<style scoped>
img{
  width: 100px;
  border-radius: 50%;
}
input{
    border-radius: 30%;
    margin: auto;
    padding: 5%;
    padding-left: 50%;
    padding-right: 50%;
}
.Barra{
    margin-top: 1%;
    display: flex;
    align-items: center;
}
form{
    margin: auto;
}
p{
    display: flex;
}
</style>