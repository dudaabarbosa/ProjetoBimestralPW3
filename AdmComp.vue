<template>
    <header>
      <div></div>
      <h2>Administrador</h2>
      <button type="button" class="btn btnadd btn-primary"  data-bs-toggle="modal" data-bs-target="#modalAdd">Adicionar livro</button>
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


<!-- Modal -->
<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h1 class="modal-title fs-5" id="exampleModalLabel">{{ nome_livro_selected }}</h1>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body container">
        <img src="" alt="" class="img_livro">
        <form>
          <div class="caixa">
            <p>Autor: {{ autor_livro_selected }}</p>
            <input type="text" placeholder="Autor">
          </div>
          <div class="caixa">
            <p>Preço: {{ preco_livro_selected }}</p>
            <input type="text" placeholder="Preço">
          </div>
          <div class="caixa">
            <p>Editora: {{ editora_livro_selected }}</p>
            <input type="text" placeholder="Editora">
          </div>
        </form>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Salvar alterções</button>
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
        <button type="button" class="btn btn-primary" @click="paraobanco">Adicionar</button>
      </div>
    </div>
  </div>
</div>

</template>

<script>
export default {
    name: "AdmComp",
    data(){
      return{
        nome_livro_selected: "",
        img_livro_selected: "",
        autor_livro_selected: "",
        preco_livro_selected: "",
        editora_livro_selected:"",
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
        fetch('https://localhost:7196/api/livro/teste', {
    method: 'POST',
    headers: {
        'Content-Type': 'application/json',
    },
    body: JSON.stringify(1),  // Enviando o número 1 diretamente no corpo da requisição
}).catch(error){
  console.error('Error:', error);
}
      }}}
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
</style>