import Vue from 'vue';
import App from './App.vue';
import BootstrapVue from 'bootstrap-vue'
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import store from './store/index'
import './Resource/css/GitHubMarkDownStyle.css'

Vue.config.productionTip = true;
Vue.use(BootstrapVue)

new Vue({
    render: h => h(App),
    store: store
}).$mount('#app');
