<template>
  <header>
    <div>
      <router-link to="/">Menu</router-link>
    </div>
    <h2>Administrador</h2>
    <button type="button" class="btn btnadd btn-primary"  data-bs-toggle="modal" data-bs-target="#modalAdd">Adicionar livro</button>
  </header>
<div class="grade">
  <div class="classe"  v-for="book in books" :key="book.livro_id" @click="showBookSelected(book.livro_id)" data-bs-toggle="modal" data-bs-target="#exampleModal">
    <img :src="book.url_img_livro" alt="">
    <p>{{book.nome_livro}}</p>
    <p>R${{book.preco}}</p>
  </div>
</div>

<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
<div class="modal-dialog">
  <div class="modal-content">
    <div class="modal-header">
      <h1 class="modal-title fs-5" id="exampleModalLabel">{{ book_selected.nome_livro }}</h1>
      <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
    </div>
    <div class="modal-body container">
      <img :src="book_selected.url_img_livro" alt="" class="img_livro">
      <form>
        <div class="caixa">
          <p>Autor: {{ book_selected.autor }}</p>
          <input type="text" placeholder="Autor" v-model="book_selected.autor">
        </div>
        <div class="caixa">
          <p>Preço: R${{ book_selected.preco }}</p>
          <input type="text" placeholder="Preço" v-model="book_selected.preco">
        </div>
        <div class="caixa">
          <p>Editora: {{ book_selected.editora }}</p>
          <input type="text" placeholder="Editora" v-model="book_selected.editora">
        </div>
      </form>
    </div>
    <div class="modal-footer">
      <button type="button" class="btn btn-primary" @click="salverAlteracoes(book_selected.livro_id)">Salvar alterações</button>
      <button type="button" class="btn btn-secondary" data-bs-dismiss="modal" @click="deletar(book_selected.livro_id)">Deletar</button>
    </div>
  </div>
</div>
</div>


<div class="modal fade" id="modalAdd" tabindex="-1" aria-labelledby="modalAddLabel" aria-hidden="true">
<div class="modal-dialog">
  <div class="modal-content">
    <div class="modal-header">
      <h1 class="modal-title fs-5" id="modalAddLabel">Modal titlkadalkjdsalke</h1>
      <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
    </div>
    <div class="modal-body">
      <form>
        <input type="text" v-model="nome_livro" placeholder="Nome do livro">
        <br>
        <input type="text" v-model="autor_livro" placeholder="Autor do livro">
        <br>
        <input type="text" v-model="preco" placeholder="Preço do livro">
        <br>
        <input type="text" v-model="paginas" placeholder="Paginas do livro">
        <br>
        <input type="text" v-model="publicacao" placeholder="Publicacao do livro">
        <br>
        <input type="text" v-model="editora" placeholder="Editora do livro">
        <br>
        <input type="file" name="arquivos" @change="adicionouImagem" accept="image/png, image/jpeg" multiple />
      </form>
    </div>
    <div class="modal-footer">
      <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Fechar</button>
      <button type="button" class="btn btn-primary" @click="paraobanco" data-bs-dismiss="modal">Adicionar</button>
    </div>
  </div>
</div>
</div>

</template>


<script>
import api from "@/services/api";
export default {
    name: "AdmComp",
    data(){
      return{
        temImg: false,
        nome_livro: '',
        autor_livro: '',
        preco: '',
        paginas: '',
        publicacao: '',
        editora: '',
        imagem: '',
        obj: {
          "nome_livro": '',
          "autor": '',
          "preco": '',
          "paginas": '',
          "publicacao": '',
          "editora": '',
          "img_livro": ''
        },
        books: [],
        book_selected: {},
        new_autor: '',
        new_editora: '',
        new_preco: '',
        atualizou: false
      }
    },
    mounted(){
      this.carregarLivros()
    },
    watch:{
      atualizou(newValue){
        if(newValue == true){
          this.carregarLivros()
          this.atualizou = false;
        }
      }
    },
    methods: {
      adicionouImagem(event){
        this.temImg = true;
        const file = event.target.files[0]; // Captura o primeiro arquivo
        const reader = new FileReader(); // Cria um leitor de arquivos
        reader.readAsDataURL(file); // Lê o arquivo como Data URL
        reader.onload = () => {
          this.imagem = reader.result; // Armazena o resultado Base64
        };
        console.log(this.imagem)
      },
      async paraobanco(){
        if(this.temImg == true){
          this.obj.nome_livro = this.nome_livro
          this.obj.autor_livro = this.autor_livro
          this.obj.editora = this.editora
          this.obj.img_livro = this.imagem
          this.obj.preco = this.preco
          this.obj.paginas = this.paginas
          this.obj.publicacao = this.publicacao
          await api.post("/livro", this.obj,{
            headers: {
              "Content-Type": "application/json",
            },
          });
          this.atualizou = true;
        }
      },
      carregarLivros(){
        api.get("/livro").then(
          response => {
            console.log(response.data)
            this.books = response.data
          }
        )
      },
      showBookSelected(id){
        api.get("/livro/id/"+id).then(
          response => {
            console.log(response.data)
            this.book_selected = response.data
          }
        )
      },
      salverAlteracoes(id){
        api.put(`/livro/alter/${id}&&${this.book_selected.autor}&${this.book_selected.preco}&${this.book_selected.editora}`)
      },
      deletar(id){
        api.delete('/livro/delete/'+id)
        this.atualizou = true
      }
    }
}
</script>

<style scoped>
.grade{
  margin-left: 50px;
  display: grid;
  grid-template-columns: 25% 25% 25% 25%;
  align-items: center;
}
.classe img:hover{
    width: 50%;
}
header{
 display: grid;
 grid-template-columns: 33% 33% 33%;
 align-items: center
}
.btnadd{
  width: 150px;
  height: 50px;
}
.container{
  display: flex;
  justify-content: space-around;
}
.caixa{
  display: grid;
  grid-template-columns: 50% 50%;
  align-items: center
}
input{
  margin-top: 8px;
}
.img_livro{
  width: 30%;
}
</style>