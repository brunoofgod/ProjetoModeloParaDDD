<template src="./Adicionar.html">
</template>
<style src="./Adicionar.scss" lang="scss">
</style>

<script>
import Datepicker from 'vuejs-datepicker'
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