import Vue from 'vue'
import Router from 'vue-router'
import Listagem from '@/pages/Contatos/Listagem/Listagem'
import Adicionar from '@/pages/Contatos/Adicionar/Adicionar'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Listagem',
      component: Listagem
    },
    {
      path: '/add',
      name: 'Adicionar',
      component: Adicionar
    }
  ]
})
