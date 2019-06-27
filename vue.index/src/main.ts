import Vue from 'vue';
import App from './App.vue';
import BootstrapVue from 'bootstrap-vue'
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import store from './store/index'
import hljs from 'highlight.js'
import 'highlight.js/styles/solarized-light.css'

Vue.config.productionTip = true;
Vue.use(BootstrapVue)

Vue.directive('highlight', function (el) {
    let blocks = el.querySelectorAll('pre code');
    blocks.forEach((block) => {
        hljs.highlightBlock(block)
    })
})

new Vue({
    render: h => h(App),
    store: store
}).$mount('#app');
