<template>
<div v-for="book in books" :key="book.livro_id">
    <img :src="book.url_img_livro" alt="">
    <p>{{ book.nome_livro }}</p>
    <p class="valor">R${{book.preco * book.quantidade}}</p>
    <div class="teste">
        <input type="number" v-model="book.quantidade" @input="calcValorTotal">
        <button @click="delProd(book.livro_id)">Excluir</button>
        </div>
</div>
<div>
    <h4>Total: {{ valor_total }}</h4>
</div>
</template>

<script>
import api from "@/services/api";
export default {
    name: "CarComp",
    data(){
        return{
            books: [],
            quantidade: 1,
            valor_total: 0,
            atualizou: false
        }
    },
    watch:{
        atualizou(newValue){
            if(newValue == true){
                this.carregarCarrinho()
                this.atualizou = false;
            }
            this.carregarCarrinho()
        }
    },
    mounted(){
        this.carregarCarrinho()
    },
    methods:{
        carregarCarrinho(){
            if(localStorage.getItem("cliente_id") == null){
                this.$router.push({ path: '/cadastro' })
            }
            else{
                api.get("/clientes/carrinho/"+localStorage.getItem('cliente_id')).then(
                response =>{
                    this.books = response.data
                    console.log(this.books)
                    this.valor_total = 0;
                    this.books.forEach((book)=>{
                        this.valor_total += book.preco*book.quantidade
                        console.log(book)
                        console.log("teste")
                    })
                    console.log(this.valor_total)
                }
            )
            }
        },
        calcValorTotal(){
            this.valor_total = 0;
            this.books.forEach((book)=>{
                        this.valor_total += book.preco*book.quantidade
                        console.log(book)
                        console.log("teste")
                    })
        },
        delProd(livro_id){
            api.delete(`/clientes/carrinho/del/${localStorage.getItem('cliente_id')}&&${livro_id}`)
            this.atualizou = true
        }
    }
}
</script>

<style scoped>
img{
    margin-left: 30px;
    width: 100px;
}
div{
    display: flex;
    margin-bottom: 30px;
    background-color: #daccf7;
    border-radius: 30px;
    
}

.valor{
    margin-left: 60%;
}
button{
    width: 80px;
    height: 30px;   
}
input{
    width: 80px;
    height: 30px;
}
.teste{
    margin-top: 80px;
    margin-left: -180px;
}
h4{
    color: black;
    margin-left: 30px;
}
</style>