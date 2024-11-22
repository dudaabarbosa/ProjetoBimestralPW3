<template>
<h2>CADASTRO</h2>
<form @submit.prevent="cadastrar">
    <input style="margin-bottom: 10px;" type="text" placeholder="Nome">
    <br>
    <input style="margin-bottom: 10px;" type="email" placeholder="Email">
    <br>
    <input style="margin-bottom: 10px;" type="text" placeholder="Telefone">
    <br>
    <input style="margin-bottom: 10px; width: 120px;" type="number" placeholder="CEP">
    <input style="width:110px; margin-left: 10px;" type="number" placeholder="N° da casa">
    <br>
    <input style="margin-bottom: 10px; margin-right: 10px;" type="password" placeholder="Senha">
    <input style="margin-bottom: 10px;" type="password" placeholder="Confirme a senha">
    <br>
    <input class="cadastrar" style="margin: auto; width: 100px; margin-top: 30px;" type="submit" value="Cadastrar">
</form>
</template>

<script>
export default {
    name: "CadastroComp",
    methods: {
        cadastrar() {
            this.$router.push({ path: '/' })
        }
    }
}
</script>

<style>
h2{
    color: black;
    margin-top: 0;
    margin-bottom: 20px;
}
input{
    border-radius: 8px;
    text-align: center;
    padding-left: 0px;
    padding-right: 0px;
}
</style>