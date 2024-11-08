<template>
<div id="carouselExample" class="carousel slide">
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="https://s2.static.brasilescola.uol.com.br/img/2019/10/dia-do-livro.jpg" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="https://artrianon.com/wp-content/uploads/2019/08/o-livro-que-te-despertou-artrianon-ok.jpg?w=800" class="d-block w-100" alt="...">
    </div>
    <div class="carousel-item">
      <img src="https://conceitos.com/wp-content/uploads/Livro.jpg" class="d-block w-100" alt="...">
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExample" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExample" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>
</template>

<script>
export default {
    name: "CarrosselComp"
}
</script>

<style scoped>
#carouselExample{
  width: 40%;
  margin: auto;
  margin-top: 20px;
}
</style>