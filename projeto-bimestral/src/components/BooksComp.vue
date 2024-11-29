<template>
<div class="grade">
<div>
<img src="https://m.media-amazon.com/images/I/6132ndvQdiL._SY466_.jpg" alt="">
<p>O Extraordinário</p>
<p class="preço">R$40,00</p>
<button>Compre</button>
</div>
<div>
<img src="https://m.media-amazon.com/images/I/91r5G8RxqfL._SY466_.jpg" alt="">
<p>É assim que acaba</p>
<p class="preço">R$44,95</p>
<button>Compre</button>
</div>
<div>
<img src="https://m.media-amazon.com/images/I/71fWaI5myqL._SY466_.jpg" alt="">
<p>Diário de um Banana</p>
<p class="preço">R$45,50</p>
<button>Compre</button>
</div>
<div>
<img src="https://m.media-amazon.com/images/I/51sqZ+7o-VL._SY445_SX342_.jpg" alt="">
<p>O poder da Ação</p>
<p class="preço">R$36,90</p>
<button>Compre</button>
</div>
<div>
<img src="https://m.media-amazon.com/images/I/81FEytag46L._SY466_.jpg" alt="">
<p>O lado feio do amor</p>
<p class="preço">R$55,41</p>
<button>Compre</button>
</div>
<div>
<img src="https://m.media-amazon.com/images/I/715h8DWokhL._SY466_.jpg" alt="">
<p>Ainda estou aqui</p>
<p class="preço">R$71,91</p>
<button>Compre</button>
</div>
<div>
<img src="https://m.media-amazon.com/images/I/4128BOZ-OhL._SY445_SX342_.jpg" alt="">
<p>Pessoas normais</p>
<p class="preço">R$119,99</p>
<button>Compre</button>
</div>
<div>
<img src="https://m.media-amazon.com/images/I/81Vhnel+xxL._SY466_.jpg" alt="">
<p class="nome">Todas as suas Imperfeições</p>
<p class="preço">R$70,40</p>
<button>Compre</button>
</div>
</div>
</template>

<script>
export default {
    name: "BooksComp"
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
