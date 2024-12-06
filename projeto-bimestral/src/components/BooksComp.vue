<template>
<div class="grade">
  <div v-for="book in books" :key="book.livro_id">
    <img :src="book.url_img_livro" alt="">
    <p>{{ book.nome_livro }}</p>
    <p class="preço">R${{ book.preco }}</p>
    <button @click="adicionarCarrinho(book.livro_id)">Compre</button>
  </div>
</div>
</template>

<script>
import api from "@/services/api";
export default {
    name: "BooksComp",
    data(){
      return{
        books: []
      }
    },
    
    mounted(){
      this.carregarLivros()
    },
    methods:{
      carregarLivros(){
        api.get("/livro").then(
          response => {
            console.log(response.data)
            this.books = response.data
          }
        )
      },
      adicionarCarrinho(livro_id){
        var obj = {'id_livro': livro_id, 'id_cliente': localStorage.getItem('cliente_id')};
        api.post("/clientes/carrinho", obj)
      }
    }
}
</script>

<style>
.grade > div{
  padding: 1em;
  border-radius: 10px;
  box-shadow: 2px 2px 25px;
  max-width: 18em;
  margin-bottom: 2em;
}

.grade > div > .preço{
  font-size: 30px;
}

.grade > div > .nome{
  font-size: 16px;
}

.grade > div > button{
  padding: 10px;
  width: 250px;
  background-color: rgb(69, 176, 142);
  color: white;
  border-radius: 5px;
}

.grade{
  margin-left: 50px;
  display: grid;
  grid-template-columns: 25% 25% 25% 25%;
  align-items: center;
}
img{
    width: 100px;
}
</style>
