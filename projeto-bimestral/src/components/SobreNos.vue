<template>
<h2>SOBRE NÓS</h2>
<table>
    <tr>
        <th>Nome</th>
        <th>Idade</th>
        <th>Frase preferida</th>
        <th>Foto</th>
    </tr>
    <tr v-for="(objeto, index) in objetos" :key="index">
        <td>{{ objeto.Nome }}</td>
        <td>{{ objeto.Idade }}</td>
        <td>{{ objeto.Frase }}</td>
        <td><img class="imagem" :src="objeto.Foto"></td>
    </tr>
</table>

</template>

<script>
export default {
    name: "SobreNos",
    data(){
        return{
            objetos: [
                {"Nome": "Eduarda Barbosa", "Idade": "17 anos", "Frase": "É isso", "Foto": require("@/assets/dudis.jpg")},
                {"Nome": "Khaléu Sanches", "Idade": "17 anos", "Frase": "Sim", "Foto": require("@/assets/babykhaleu.jpg") }]
        }
    }

}
</script>

<style>

p{
    margin: 30px;
}

table{
    margin: auto;
    border: 2px solid black;
    margin-bottom: 10px;
}
.imagem {
    width: 60%;
    border-radius: 30%;
}
td, th{
    padding: 15px;
    border: 2px solid black;
}
td{
    width: 250px;
    text-align: center;
}
h2{
    margin-top: 30px;
    text-align: center;
}
</style>