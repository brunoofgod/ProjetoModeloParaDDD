<template>
  <div class="adicionar">
    <form >
        <md-layout >
            <md-layout  class="padding15">
                <md-input-container >
                    <label>Nome do vendedor</label>
                    <md-input maxlength="150" v-model="nomeDoVendedor"></md-input>
                </md-input-container>
            </md-layout>
            <md-layout class="padding15">
                <md-input-container >
                    <label>Nome da empresa</label>
                    <md-input v-model="nomeDaEmpresa" maxlength="150"></md-input>
                </md-input-container>
            </md-layout>
            <md-layout v-model="nomeDoContato" class="padding15">
                <md-input-container >
                    <label>Nome do contato</label>
                    <md-input v-model="nomeDoContato" maxlength="150"></md-input>
                </md-input-container>
            </md-layout>
        </md-layout>
        <md-layout >
            <md-layout class="padding15">
                <md-input-container  >
                    <label>Sobrenome do contato</label>
                    <md-input v-model="sobreNomeDoContato" maxlength="150"></md-input>
                </md-input-container>
            </md-layout>
            <md-layout class="padding15">
                <md-input-container   >
                    <md-icon>mail_outline</md-icon>
                    <label class="padLef10">Email</label>
                    <md-input v-model="email" maxlength="150"></md-input>
                </md-input-container>
            </md-layout>  
            <md-layout class="padding15" >
                <md-input-container >
                    <md-icon>phone</md-icon>
                    <label class="padLef10">Telefone</label>
                    <md-input v-model="telefone" maxlength="70" type="number"></md-input>
                </md-input-container>
            </md-layout>  
        </md-layout>  
        <md-layout >
            <md-layout class="padding15">
                <label>Data de validade</label>
                <datepicker v-model="dataDeValidade" ></datepicker>
            </md-layout>  
            <md-layout class="padding15">
                <label>Data de Contato</label>
                    <datepicker v-model="dataDeContato" ></datepicker>
            </md-layout>  
            <md-layout>
                <md-button class="md-icon-button md-raised" @click="enviarContato($event)" >
                    <md-icon>add</md-icon>
                </md-button>                
            </md-layout>  
        </md-layout>  
    </form>


    <md-dialog-alert
        :md-content="erro.content"
        :md-ok-text="erro.ok"
        @open="onOpen"
        @close="onClose"
        ref="erro">
    </md-dialog-alert>
  </div>
</template>

<script>
import Datepicker from 'vuejs-datepicker';
import axios from 'axios'

export default {
    name: 'Adicionar',
    props:{
    },
    components: {
        Datepicker
    },
    data () {
        return {
            nomeDoVendedor : "",
            nomeDaEmpresa :  "",
            nomeDoContato : "",
            sobreNomeDoContato : "",
            email :  "",
            telefone : "",
            dataDeValidade : "",
            dataDeContato : "",
            erro: {
                content: 'Ocorreu um erro ao incluir o contato.',
                ok : "OK"
            },
        }
    },
    methods: {
        enviarContato(){
            axios.post('http://localhost:58210/api/Contato/',
                 {
                    NomeDoVendedor: this.nomeDoVendedor,
                    NomeDaEmpresa: this.nomeDaEmpresa,
                    NomeDoContato: this.nomeDoContato,
                    SobreNomeDoContato: this.sobreNomeDoContato,
                    Email: this.email,
                    Telefone: this.telefone,
                    DataDeContato: this.dataDeContato,
                    DataDeValidade: this.dataDeValidade
                }).then((resp) => {
                    window.location.href = '/';
                })
                .catch((err) => {
                   this.$refs["erro"].open();
                });

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

