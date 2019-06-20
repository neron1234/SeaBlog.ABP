import Vue from 'vue';
import Vuex from 'vuex';
import SiteConfig from './modules/siteConfig'
import Category from './modules/category'
import Blog from './modules/blog'

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
        Category,
        Blog
    }
});

export default store;