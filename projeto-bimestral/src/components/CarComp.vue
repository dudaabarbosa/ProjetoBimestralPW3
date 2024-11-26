<template>
<div>
<img src="https://m.media-amazon.com/images/I/6132ndvQdiL._SY466_.jpg" alt="">
<p>O Extraordinário</p>
<p class="valor">R$35,80</p>
<div class="teste">
<input type="number">
<button>Excluir</button>
</div>
</div>
<div>
<img src="https://m.media-amazon.com/images/I/91r5G8RxqfL._SY466_.jpg" alt="">
<p>É assim que acaba</p>
<p class="valor">R$26,10</p>
<div class="teste">
<input type="number">
<button>Excluir</button>
</div>
</div>
<div>
<img src="https://m.media-amazon.com/images/I/71fWaI5myqL._SY466_.jpg" alt="">
<p>Diário de um Banana</p>
<p class="valor">R$42,50</p>
<div class="teste">
<input type="number">
<button>Excluir</button>
</div>
</div>
<div>
<img src="https://m.media-amazon.com/images/I/51sqZ+7o-VL._SY445_SX342_.jpg" alt="">
<p>O poder da Ação</p>
<p class="valor">R$32,90</p>
<div class="teste">
<input type="number">
<button>Excluir</button>
</div>
</div>
<div>
    <h4>Total:</h4>
</div>
</template>

<script>
export default {
    name: "CarComp"
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