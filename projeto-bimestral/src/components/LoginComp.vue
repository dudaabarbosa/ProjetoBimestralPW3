<template>
    <h2>LOGIN</h2>
    <div class="caixinhas">
        <form @submit.prevent="logar">
            <input style="margin-bottom: 10px;" type="email" placeholder="Email">
            <br>
            <input style="margin-bottom: 10px;" type="password" placeholder="Senha">
            <br>
                <input style="margin: auto;" type="submit" value="Logar">
        </form>
    </div>
</template>

<script>
export default {
    name: "LoginComp",
    methods: {
        logar() {
            this.$router.push({ path: '/Home' })
        }
    }
}
</script>

<style>

root {
    --bargronaldpo: #111111;
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


/* 
font-size - 2rem - 1rem = 16px */
</style>