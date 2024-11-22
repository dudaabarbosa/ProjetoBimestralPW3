<template>
    <h3>Contato</h3>
    <form @submit.prevent="handleSubmit"> 
        <label>Digite seu email:</label> 
        <input type="text" placeholder="Email">
        <br>
        <label>Selecione o assunto:</label>
        <select name="Assunto" id="Assunto">
        <option value="Duvidas">Dúvidas</option>
        <option value="Reclamacao">Reclamação</option>
        <option value="maisinfo">Mais informações</option>
        </select>
        <br>
        <label>Digite a mensagem:</label>
        <textarea name="Mensagem" id="Mensagem"></textarea>
        <br>
        <input class="enviar" type="submit" value="Enviar">

    </form>
    
    <div v-if="showModal" class="modal-overlay">
        <div class="modal-content">
            <h3>Mensagem enviada!</h3>
            <p>Sua mensagem foi enviada com sucesso, logo você receberá retorno</p>
            <button @click="closeModal" class="close-button">Fechar</button>
        </div>
    </div>
    
    </template>
    
    <script>
    export default {
        name: "ContactComp",
        data(){
            return {
                showModal: false,
            }
        }, 
        methods: {
            handleSubmit(){
                this.showModal= true
            },
        closeModal(){
            this.showModal = false
            }
        }
    }
    </script>
    
    <style>
    h3{
        margin-top: 20px;
    }

    label{
        margin: 20px;
    }
    
    .modal-overlay{
        position: fixed;
        top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        background-color: #9a70f0;
        display: flex;
        justify-content: center;
        align-items: center;
        z-index: 1000;
    }
    
    .close-button{
        margin: auto;
        width: 15%;
        border-radius: 30px;
    }

    .enviar{
        border-radius: 30px;
        padding: 3px;
        padding-left: 40px;
        padding-right: 40px;
        background-color: black;
        color: white;
        font-family: Poppins;
        font-weight: 500;
    }

    footer{
        position: absolute;
    }

    </style>