<template>
  <div class="Listagem">
    <h3 class="titulo">Contatos cadastrados</h3>
    <hr>
    <div class="row">
      <div class="col-md-12 botoes-top">
        <router-link to="/add" class="btn btn-success">Adicionar novo</router-link>
      </div>
    </div>
    <div class="row">
        
      <table class="table">
        <thead>
          <tr>
            <th>Nome do vendedor</th>
            <th>Nome da empresa</th>
            <th>Nome do contato</th>
            <th>Sobrenome do contato</th>
            <th>Email</th>
            <th>Telefone</th>
            <th>Data de validade</th>
            <th>Data de contato</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
          </tr>
        </tbody>
      </table>
    </div>
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

