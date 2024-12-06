<template>
<h2>SOBRE NÓS</h2>
<table>
    <tr>
        <th>Nome</th>
        <th>Idade</th>
        <th>Hobby</th>
    </tr>
    <tr v-for="(objeto, index) in objetos" :key="index">
        <td>{{ objeto.Nome }}</td>
        <td>{{ objeto.Idade }}</td>
        <td>{{ objeto.Hobby }}</td>
    </tr>
</table>

</template>

<script>
export default {
    name: "SobreNos",
    data(){
        return{
            objetos: [
                {"Nome": "Eduarda Barbosa", "Idade": "17 anos", "Hobby": "Dançar"},
                {"Nome": "Khaléu", "Idade": "17 anos", "Hobby": "Programar",},
                {"Nome": "Luís", "Idade": "18 anos", "Hobby": "Programar",}
            ]
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
    width: 80%;
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
    margin-top: 50px;
    margin-bottom: 60px;
    text-align: center;
}
</style>