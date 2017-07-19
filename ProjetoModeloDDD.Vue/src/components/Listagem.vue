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
            <md-table-row v-for="(row, index) in 80" :key="index">
              <md-table-cell>Um valor qualquer</md-table-cell>
              <md-table-cell v-for="(col, index) in 7" :key="index">10</md-table-cell>
            </md-table-row>
          </md-table-body>
          </md-table>
        </div>
</template>
<script>
export default {
  name: 'Listagem',
  data () {
    return {
      msg: 'Welcome to Contatos'
    }
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

