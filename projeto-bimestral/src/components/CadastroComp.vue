<template>
<h2>CADASTRO</h2>
<div>
<form @submit.prevent="cadastrar">
    <input style="margin-bottom: 10px;" type="text" placeholder="Nome" required>
    <br>
    <input style="margin-bottom: 10px;" type="email" placeholder="Email" required>
    <br>
    <input style="margin-bottom: 10px;" type="text" placeholder="Telefone" required>
    <br>
    <input style="margin-bottom: 10px; width: 120px;" type="number" placeholder="CEP" required>
    <input style="width:110px; margin-left: 10px;" type="number" placeholder="N° da casa" required>
    <br>
    <input style="margin-bottom: 10px; margin-right: 10px;" type="password" placeholder="Senha" required>
    <br>
    <input style="margin-bottom: 10px;" type="password" placeholder="Confirme a senha" required>
    <br>
    <button class="cadastrar" style="margin: auto; width: 100px; margin-top: 30px;" type="submit" value="Cadastrar">Cadastrar</button>
</form>
</div>
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

<style scoped>
h2{
    color: black;
    margin-top: -30px;
    margin-bottom: 20px;
}

input{
    background-color: #9a70f0;
    text-align: center;
    border: 0;
    border-bottom: 2px solid black;
    color: black;
    width: 150px;
}
button{
    height: 30px;
    border-radius: 20px;
    color: black;
}
input::placeholder{
    color: black;
}

</style>