import Vue from 'vue';
import Vuex from 'vuex';
import SiteConfig from './modules/siteConfig'

Vue.use(Vuex);

const store = new Vuex.Store({
    state: {
        //
    },
    mutations: {
        //
    },
    actions: {

    },
    modules: {
        SiteConfig
    }
});

export default store;