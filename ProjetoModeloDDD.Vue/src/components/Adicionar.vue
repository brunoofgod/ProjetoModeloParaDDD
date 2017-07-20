<template>
  <div class="adicionar">
    <form novalidate @submit.stop.prevent="submit">
        <md-layout >
            <md-layout  class="padding15">
                <md-input-container >
                    <label>Nome do vendedor</label>
                    <md-input maxlength="150"></md-input>
                </md-input-container>
            </md-layout>
            <md-layout class="padding15">
                <md-input-container >
                    <label>Nome da empresa</label>
                    <md-input maxlength="150"></md-input>
                </md-input-container>
            </md-layout>
            <md-layout  class="padding15">
                <md-input-container >
                    <label>Nome do contato</label>
                    <md-input maxlength="150"></md-input>
                </md-input-container>
            </md-layout>
        </md-layout>
        <md-layout >
            <md-layout class="padding15">
                <md-input-container  >
                    <label>Sobrenome do contato</label>
                    <md-input maxlength="150"></md-input>
                </md-input-container>
            </md-layout>
            <md-layout class="padding15">
                <md-input-container   >
                    <md-icon>mail_outline</md-icon>
                    <label class="padLef10">Email</label>
                    <md-input maxlength="150"></md-input>
                </md-input-container>
            </md-layout>  
            <md-layout class="padding15" >
                <md-input-container >
                    <md-icon>phone</md-icon>
                    <label class="padLef10">Telefone</label>
                    <md-input maxlength="70" type="number"></md-input>
                </md-input-container>
            </md-layout>  
        </md-layout>  
        <md-layout >
            <md-layout class="padding15">
                <md-input-container  >
                    <label>Data de validade</label>
                    <md-input maxlength="70"></md-input>
                </md-input-container>
            </md-layout>  
            <md-layout class="padding15">
                <md-input-container  >
                    <label>Data de contato</label>
                    <md-input maxlength="70"></md-input>
                </md-input-container>
            </md-layout>  
        <md-layout></md-layout>  
        </md-layout>  
        <md-bottom-bar>
            <md-bottom-bar-item md-iconset="icon-speedometer">Recents</md-bottom-bar-item>
            <md-bottom-bar-item md-iconset="icon-heart" md-active>Favorites</md-bottom-bar-item>
            <md-bottom-bar-item md-iconset="icon-cursor">Nearby</md-bottom-bar-item>
        </md-bottom-bar> 
    </form>
  </div>
</template>

<script>
    export default {
        name: 'Adicionar',
        props:{

        },
        data () {
            return {
                nomeDoVendedor : String,
                nomeDaEmpresa : String,
                nomeDoContato : String,
                sobreNomeDoContato : String,
                email : String,
                dataCadastro : String,
                telefone : String,
                dataDeValidade : String,
                dataDeContato : String
            }
        }
    }
</script>
<style scopped>
    .padding15{
        padding: 15px;  
    }
    .padLef10{
        padding-left: 10px;
    }
</style>

