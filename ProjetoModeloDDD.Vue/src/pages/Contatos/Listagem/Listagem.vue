<template src="./Listagem.html">
</template>
<style src="./Listagem.scss" lang="scss">
</style>

<script>

import axios from 'axios'

export default {
  name: 'Listagem',
  data () {
    return {
      contatos: [],
        erro: {
        content: 'Ocorreu um erro ao excluir o contato.',
        ok: "Ok"
      },
    }
  },  
  methods: {
    getContatos () {
      axios.get('http://localhost:58210/api/Contato/' )
        .then((resp) => {
          console.log(resp);
          this.contatos = resp.data;
        })
        .catch((err) => {
          console.log(err)
        });
    },
    deleteContato (id) {
      axios.delete('http://localhost:58210/api/Contato/'+ id )
        .then((resp) => {
          this.contatos = resp.data;
        })
        .catch((err) => {
        });
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