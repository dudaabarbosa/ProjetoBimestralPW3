<template>
<h2>CADASTRO</h2>
<div>
<form @submit.prevent="cadastrar">
    <input style="margin-bottom: 10px;" v-model="nome" type="text" placeholder="Nome" required>
    <br>
    <input style="margin-bottom: 10px;" v-model="email" type="email" placeholder="Email" required>
    <br>
    <input style="margin-bottom: 10px;" v-model="telefone" type="text" placeholder="Telefone" required>
    <br>
    <input style="margin-bottom: 10px; width: 120px;" v-model="cep" max="999999999" type="number" placeholder="CEP" required>
    <input style="width:110px; margin-left: 10px;" v-model="numero_residencia" max="999" type="number" placeholder="N° da casa" required>
    <br>
    <input style="margin-bottom: 10px; margin-right: 10px;" v-model="senha" type="password"  placeholder="Senha" required>
    <br>
    <input style="margin-bottom: 10px;" v-model="senha_confirm" type="password" placeholder="Confirme a senha" required>
    <br>
    <button class="cadastrar" style="margin: auto; width: 100px; margin-top: 30px;" type="submit" value="Cadastrar">Cadastrar</button>
</form>
</div>
</template>

<script>
import api from "@/services/api"
export default {
    name: "CadastroComp",
    data(){
        return{
            nome:'',
            senha:'',
            senha_confirm:'',
            cep:'',
            telefone:'',
            numero_residencia:'',
            email:'',
            obj: {
                nome:'',
                senha:'',
                cep:'',
                telefone:'',
                numero_residencia:'',
                email:''
            }
        }
    },
    methods: {
        cadastrar() {
            if(this.senha_confirm == this.senha){
                this.obj.nome = this.nome
                this.obj.senha = this.senha
                this.obj.email = this.email
                this.obj.cep = this.cep+""
                this.obj.telefone = this.telefone+""
                this.obj.numero_residencia = this.numero_residencia+""
                api.post("/clientes", this.obj)
                this.$router.push({ path: '/login' })
            }
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