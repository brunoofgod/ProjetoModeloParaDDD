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
            dataDeValidade : null,
            dataDeContato : null,
            erro: {
                content: 'Ocorreu um erro ao incluir o contato.',
                ok : "OK"
            },
            validador: {
                vendedor: String,
                contato: String,
                email: String,
                telefone: String
            },
            errorClass: "md-input-invalid"
        }
    },
    methods: {
        enviarContato(ev){
            this.validator();
            if(!this.validador.passou) return;

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

        },
        validator(){
            this.validador.passou = true;
            if(this.nomeDoVendedor == "") {
                this.validador.passou = false;
                this.validador.vendedor = this.errorClass;
            }
            if(this.nomeDoContato == ""){
                this.validador.passou = false;
                this.validador.contato = this.errorClass;
            }
            if(this.email == ""){
                this.validador.passou = false;
                this.validador.email = this.errorClass;
            }
            if(this.telefone == ""){
                this.validador.passou = false;
                this.validador.telefone = this.errorClass;
            }
        }
    },

}
</script>