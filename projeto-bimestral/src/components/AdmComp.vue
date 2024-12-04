<template>
    <header>
<h2>Administrador</h2>
    </header>
<div class="grade">
<div class="classe" data-bs-toggle="modal" data-bs-target="#exampleModal">
<img src="https://m.media-amazon.com/images/I/6132ndvQdiL._SY466_.jpg" alt="">
<p>O Extraordinário</p>
<p>R$35,80</p>
</div>
<div>
<img src="https://m.media-amazon.com/images/I/91r5G8RxqfL._SY466_.jpg" alt="">
<p>É assim que acaba</p>
<p>R$26,10</p>
</div>
<div>
<img src="https://m.media-amazon.com/images/I/71fWaI5myqL._SY466_.jpg" alt="">
<p>Diário de um Banana</p>
<p>R$42,50</p>
</div>
<div>
<img src="https://m.media-amazon.com/images/I/51sqZ+7o-VL._SY445_SX342_.jpg" alt="">
<p>O poder da Ação</p>
<p>R$32,90</p>
</div>
<div>
<img src="https://m.media-amazon.com/images/I/81FEytag46L._SY466_.jpg" alt="">
<p>O lado feio do amor</p>
<p>R$86,70</p>
</div>
<div>
<img src="https://m.media-amazon.com/images/I/715h8DWokhL._SY466_.jpg" alt="">
<p>Ainda estou aqui</p>
<p>R$120,35</p>
</div>
<div>
<img src="https://m.media-amazon.com/images/I/4128BOZ-OhL._SY445_SX342_.jpg" alt="">
<p>Pessoas normais</p>
<p>R$77,40</p>
</div>
<div>
<img src="https://m.media-amazon.com/images/I/81Vhnel+xxL._SY466_.jpg" alt="">
<p>Todas as suas IMperfeições</p>
<p>R$48,90</p>
</div>
</div>
<!-- Button trigger modal -->
<button type="button" class="btn btn-primary" >
  Launch demo modal
</button>
<button type="button" class="btn btn-primary"  data-bs-toggle="modal" data-bs-target="#modalAdd">add livro</button>

<!-- Modal -->
<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h1 class="modal-title fs-5" id="exampleModalLabel">Modal title</h1>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        ...
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Save changes</button>
        <button type="button">Deletar</button>
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
          <input type="text" v-model="autor_livro" placeholder="Autor do livro">
          <input type="text" v-model="preco" placeholder="Preço do livro">
          <input type="text" v-model="paginas" placeholder="Paginas do livro">
          <input type="text" v-model="publicacao" placeholder="Publicacao do livro">
          <input type="text" v-model="editora" placeholder="Editora do livro">
          <input type="text" v-model="imagem" placeholder="Imagem do livro">
        </form>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Fechar</button>
        <button type="button" class="btn btn-primary" click="paraobanco">Adicionar</button>
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
        nome_livro: '',
        autor_livro: '',
        preco: '',
        paginas: '',
        publicacao: '',
        editora: '',
        imagem: '',
        obj: {
          "nome_livro": '',
          "autor_livro": '',
          "preco": '',
          "paginas": '',
          "publicacao": '',
          "editora": '',
          "imagem": ''
        }
      }
    },
    methods: {
      paraobanco(){
        this.obj.nome_livro = this.nome_livro
        api.post("/croiarlivro/")
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
</style>