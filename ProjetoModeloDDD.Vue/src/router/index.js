import Vue from 'vue'
import Router from 'vue-router'
import Listagem from '@/components/Listagem'
import Adicionar from '@/components/Adicionar'

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
