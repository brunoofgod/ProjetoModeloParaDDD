<template>
        <div>
          <md-table>
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
            <md-table-row v-for="(contato, index) in contatos" :key="index">
              <md-table-cell>{{contato.NomeDoVendedor}}</md-table-cell>
              <md-table-cell>{{contato.NomeDaEmpresa}}</md-table-cell>
              <md-table-cell>{{contato.NomeDoContato}}</md-table-cell>
              <md-table-cell>{{contato.SobreNomeDoContato}}</md-table-cell>
              <md-table-cell>{{contato.Email}}</md-table-cell>
              <md-table-cell>{{contato.Telefone}}</md-table-cell>
              <md-table-cell>{{getDataFormatada(contato.DataDeValidade)}}</md-table-cell>
              <md-table-cell>{{getDataFormatada(contato.DataDeContato)}}</md-table-cell>
              <md-table-cell>
                <md-button class="md-icon-button md-raised">
                  <md-icon>add</md-icon>
                </md-button>

              </md-table-cell>
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
          console.log(this);
          this.contatos = resp.data;
        })
        .catch((err) => {
          console.log(err)
        })
    },
    getDataFormatada(data){
      var dataFormatada = new Date(data)    
      return dataFormatada.getDate() + "/" + dataFormatada.getMonth() + "/" +dataFormatada.getFullYear() ;
    } 
  },
  created(){
    this.getContatos();
  },
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

