<!-- Use esse HTML e CSS aqui  -->

<!-- CSS 
Instale por NPM os icones
$ npm install boxicons --save
import 'boxicons'

<style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 95vh;
            background-color: rgb(255, 255, 255);
            background-size: cover;
            background-position: center;
        }

        .wrapper{
            background: transparent;
            width: 620px;
            color: rgb(0, 0, 0);
            border: 2px solid white;
            box-shadow: 0 0 10px rgb(39, 39, 39);
            border-radius: 10px;
            padding: 30px 40px;
            backdrop-filter: blur(20px);
            font-family: Arial, Helvetica, sans-serif;
        }

        .wrapper h1 {
            font-size: 36px;
            text-align: center;
        }

        .wrapper .input-box{
            position: relative;
            width: 100%;
            height: 50px;
            margin: 30px 0;
        }

        .input-box input{
            width: 100%;
            height: 100%;
            background: transparent;
            border: none;
            outline: none;
            border: 2px solid rgb(0, 0, 0);
            border-radius: 40px;
            font-size: 16px;
            color: rgb(0, 0, 0);
            padding: 20px 45px 20px 20px;
        }

        .input-box input::placeholder{
            color: rgb(0, 0, 0);
        }

        .input-box i {
            position: absolute;
            right: 20px;
            top: 50%;
            transform: translateY(-50%);
            font-size: 20px;
        }

        .wrapper .forget{
            display: flex;
            justify-content: space-between;
            font-size: 15px;
            margin: -15px 0 15px;
        }

        .forget label input {
            accent-color: rgb(0, 0, 0);
            margin-right: 3px;
        }

        .forget a{
            color: rgb(0, 0, 0);
            text-decoration: none;
        }
        
        .forget a:hover{
            text-decoration: underline;
        }

        .wrapper .btn{
            width: 100%;
            height: 45px;
            background: white;
            border: none;
            outline: none;
            border-radius: 40px;
            box-shadow: 0 0 10px rgb(0, 0, 0);
            cursor: pointer;
            font-size: 16px;
            color: black;
            font-weight: 600px;
        }

        .wrapper .sing-up{
            font-size: 15px;
            text-align: center;
            margin: 20px 0 15px;
        }

        .sing-up a{
            color: rgb(0, 0, 0);
            text-decoration: none;
            font-weight: 600px;
        }

        .sing-up a:hover{
            text-decoration: underline;
        } -->

       <!--  HTML
    <div class="wrapper">
        <form action="">
            <h1>Logar</h1>
            <div class="input-box">
                <input type="text" placeholder="E-mail" required>
                <i class='bx bxs-user-circle'></i>
            </div>
            <div class="input-box">
                <input type="password" placeholder="Password" required>
                <i class='bx bxs-lock'></i>
            </div>
            <div class="forget">
                <label><input type="checkbox">Esqueceu a senha?</label><a href="">clique aqui</a>
            </div>
            <button type="submit" class="btn">Entrar</button>
            <div class="sing-up">
                Não tem uma senha? <a href="">clique aqui</a>
            </div>
        </form>
    </div>
-->

<template>
    <h2 class="logar">LOGIN</h2>
    <div class="caixinhas">
        <form @submit.prevent="logar">
            <input style="margin-bottom: 10px;" type="email" placeholder="Email">
            <br>
            <input style="margin-bottom: 10px;" type="password" placeholder="Senha">
            <br>
                <input style="margin: auto; width: 80px;" type="submit" value="Logar">
        </form>
    </div>
    <p>Não tem uma conta?</p>
    <router-link style="color: inherit;" to="/cadastro">Cadastre-se</router-link>
</template>

<script>
export default {
    name: "LoginComp",
    methods: {
        logar() {
            this.$router.push({ path: '/' })
        }
    }
}
</script>

<style scoped>

root {
    --bargronaldpo: #111111;
}
.logar{
    margin: 0;
    margin-bottom: 30px;
 }
 
.caixinhas{
    display: flex;
    justify-content: center;
}

form {
    display: flex;
    flex-direction: column;
    color: var(--bargronaldpo);
}
input{
    border-radius: 50px;
    text-align: center;
}


/* 
font-size - 2rem - 1rem = 16px */
</style>
