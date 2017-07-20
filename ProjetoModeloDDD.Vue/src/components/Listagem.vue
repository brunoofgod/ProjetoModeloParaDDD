<template>
        <div>
          <md-table v-once >
            <md-table-header>
              <md-table-row>
                <md-table-head >Nome do vendedor</md-table-head>
                <md-table-head>Nome da empresa</md-table-head>
                <md-table-head >Nome do contato</md-table-head>
                <md-table-head>Sobrenome do contato</md-table-head>
                <md-table-head>Email</md-table-head>
                <md-table-head md-numeric>Telefone</md-table-head>
                <md-table-head >Data de validade</md-table-head>
                <md-table-head >Data de contato</md-table-head>
              </md-table-row>
            </md-table-header>
          <md-table-body>
            <md-table-row v-for="(contato, index) in contatos" :key="index">

              <md-table-cell></md-table-cell>
              <md-table-cell>Um lvalor quaquer</md-table-cell>
              <md-table-cell>Um lvalor quaquer</md-table-cell>
              <md-table-cell>Um lvalor quaquer</md-table-cell>
              <md-table-cell>Um lvalor quaquer</md-table-cell>
              <md-table-cell>Um lvalor quaquer</md-table-cell>
              <md-table-cell>Um lvalor quaquer</md-table-cell>
              <md-table-cell>Um lvalor quaquer</md-table-cell>

            </md-table-row>
          </md-table-body>
          </md-table>
        </div>
</template>
<script>

import axios from 'axios'

export default {
  name: 'Listagem',
  data () {
    return {
      contatos: []
    }
  },  
  methods: {
    getContatos () {
      axios.get('http://localhost:58210/api/Contato/' )
        .then((resp) => {
          contatos = JSON.parse(resp.data);
          console.log(resp)
        })
        .catch((err) => {
          console.log(err)
        })
    }
  },
  beforeMount(){
    this.getContatos();
  }
}
</script>
<style scopped>
  .titulo{
    text-align: center;
    padding: 15px !important;
    margin: 0 ;
  }
  .btn-success{
    margin-top: 18px;
  }
  .botoes-top{
    text-align: right;
    margin: 0 10px 20px 0;
  }
</style>

