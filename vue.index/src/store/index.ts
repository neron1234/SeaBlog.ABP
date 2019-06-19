import Vue from 'vue';
import Vuex from 'vuex';
import SiteConfig from './modules/siteConfig'
import Category from './modules/category'

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
        SiteConfig,
        Category
    }
});

export default store;