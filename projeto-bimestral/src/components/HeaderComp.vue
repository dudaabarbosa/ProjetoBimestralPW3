<template>
<header>
    <!-- <nav class="navbar navbar-light bg-light navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">
      <img src="/projeto-bimestral/src/assets/Logo.png" alt="" >
    </a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="#">Home</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Link</a>
        </li>
        <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Dropdown
          </a>
          <ul class="dropdown-menu">
            <li><a class="dropdown-item" href="#">Action</a></li>
            <li><a class="dropdown-item" href="#">Another action</a></li>
            <li><hr class="dropdown-divider"></li>
            <li><a class="dropdown-item" href="#">Something else here</a></li>
          </ul>
        </li>
        <li class="nav-item">
          <a class="nav-link disabled" aria-disabled="true">Disabled</a>
        </li>
      </ul>
      <form class="d-flex" role="search">
        <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search">
        <button class="btn btn-outline-success" type="submit">Search</button>
      </form>
    </div>
  </div>
</nav> -->




    <div class="Barra">
        <img alt="logo" src="../assets/Logo.png">
        <form action="">
            <input type="text" placeholder="Pesquisar">
        </form>
        <div class="lo-ca">
        <router-link style="text-decoration: none; color: inherit; margin-right: 30px;" to="/login"><img src="../assets/perfil.png" style="width:64px"></router-link>
        <router-link style="text-decoration: none; color: inherit; margin-right: 80px;" to="/home">Carrinho</router-link>
        </div>
    </div>

    <nav>
        <router-link style="text-decoration: none; color: inherit; margin-right: 80px;" to="/">Home</router-link>
        <router-link style="text-decoration: none; color: inherit; margin-right: 80px;" to="/sobre">Sobre nós</router-link>
        <router-link style="text-decoration: none; color: inherit;" to="/contato">Contato</router-link>
    </nav>
</header>
</template>

<script>
export default {
    name: "HeaderComp",
    components: {
    }
}
</script>

<style scoped>
img{
  width: 120px;
  border-radius: 50%;
}
header{
    background-color: #9a70f0;
}
.Barra{
  display: grid;
  grid-template-columns: 33% 33% 33%;
  align-items: center;
}
form {
    display: flex;
    flex-direction: column;
    color: var(--bargronaldpo);
}
.caixinhas{
    display: flex;
    justify-content: center;
}
</style>