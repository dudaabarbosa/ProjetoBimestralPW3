<template>
<div class="grade">
<div>
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
</template>

<script>
export default {
    name: "BooksComp"
}
</script>

<style>
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