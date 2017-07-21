<template>
  <div id="app">
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
    <link rel="stylesheet" href="//fonts.googleapis.com/css?family=Roboto:300,400,500,700,400italic">
    <link rel="stylesheet" href="//fonts.googleapis.com/icon?family=Material+Icons">

    <div class="app-viewport" id="file-list">
      <md-sidenav class="md-left md-fixed" ref="sidebar">
        <md-toolbar class="md-account-header">
          <md-list class="md-transparent">
            <md-list-item class="md-avatar-list">
              <md-avatar class="md-large">
                <img src="../src/assets/avatar.jpg" alt="People">
              </md-avatar>
            </md-list-item>
            <md-list-item>
              <div class="md-list-text-container">
                <span>Bruno de Deus</span>
                <span>brunoofgod@gmail.com</span>
              </div>
      
              <md-button class="md-icon-button md-list-action">
                <md-icon>arrow_drop_down</md-icon>
              </md-button>
            </md-list-item>
          </md-list>
        </md-toolbar>
      
        <md-list class="bgwhite">
          <router-link :to="{ name: 'Listagem' }">
            <md-list-item @click="$refs.sidebar.toggle()" class="md-default bgwhite">
              <md-icon>home</md-icon> <span>Listar</span>
            </md-list-item>
          </router-link>
            <router-link to="/add">
              <md-list-item @click="$refs.sidebar.toggle()" class="md-default  bgwhite">
                <md-icon>add_box</md-icon> <span>Adicionar</span>
              </md-list-item>
          </router-link>
          
        </md-list>
      </md-sidenav>
  
      <md-whiteframe md-elevation="3" class="main-toolbar">
        <md-toolbar class="md-large">
          <div class="md-toolbar-container">
            <md-button class="md-icon-button" @click="$refs.sidebar.toggle()">
              <md-icon>menu</md-icon>
            </md-button>
            <span style="flex: 1"></span>
          </div>
      
          <div class="md-toolbar-container">
            <h2 class="md-title">Gerenciador de contatos</h2>
            <router-link to="/add">
              <md-button class="md-fab md-mini">
                <md-icon>add</md-icon>
              </md-button>
            </router-link>
          </div>
        </md-toolbar>
      </md-whiteframe>
  
      <main class="main-content">
        <transition name="md-router" appear>
          <router-view></router-view>
        </transition>
      </main>
    </div>
  </div>
</template>

<script>
export default {
  name: 'app',
}
</script>
<style>

html,
body,
.app-viewport {
  height: 100%;
  overflow: hidden;
}

.app-viewport {
  display: flex;
  flex-flow: column;
}

.main-toolbar {
  position: relative;
  z-index: 10;
}

.md-fab {
  margin: 0;
  position: absolute;
  bottom: -20px;
  left: 16px;
  z-index: 10;
  
  .md-icon {
    color: #fff;
  }
}

.md-title {
  padding-left: 8px;
  color: #fff;
}

.main-content {
  position: relative;
  z-index: 1;
  overflow: auto;
}

.md-list-action .md-icon {
  color: rgba(#000, .26);
}

.md-avatar-icon .md-icon {
  color: #fff !important;
}

.md-sidenav .md-list-text-container > :nth-child(2) {
  color: rgba(#fff, .54);
}

.md-account-header {
  .md-list-item:hover .md-button:hover {
    background-color: inherit;
  }

  .md-avatar-list .md-list-item-container:hover {
    background: none !important;
  
  }
}

  .md-sidenav-content, bgwhite{
    background-color: white !important;
  }
</style>

