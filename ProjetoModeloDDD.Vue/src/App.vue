<template>
  <div id="app">
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
      <div class="navbar navbar-inverse">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                  <li><router-link :to="{ name: 'Listagem' }">Listar</router-link></li>
                  <li><router-link to="/add">Cadastrar</router-link></li>
                  <li><router-link to="/edit/ethereum">Editar</router-link></li>
                  <li><router-link to="/edit/bitcoin">Editar Bitcoin</router-link></li>
                </ul>
            </div>
        </div>
    </div>
    <router-view></router-view>
  </div>
</template>

<script>
export default {
  name: 'app'
}
</script>
<style>
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
  input{
    width: 90% !important;
  }
  .row{
        margin: 10px !important;
    }
</style>

