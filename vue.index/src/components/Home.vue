<template>
    <div class="main">
        <b-navbar toggleable="lg" type="dark" variant="info">
            <div class="container">
                <b-navbar-brand href="/">{{siteConfig.name}}</b-navbar-brand>

                <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>

                <b-collapse id="nav-collapse" is-nav>
                    <b-navbar-nav>
                        <b-nav-form>
                            <b-form-input size="sm" class="mr-sm-2" placeholder="Search"></b-form-input>
                            <b-button size="sm" class="my-2 my-sm-0" type="submit" variant="primary">Search</b-button>
                        </b-nav-form>
                    </b-navbar-nav>

                    <!-- Right aligned nav items -->
                    <b-navbar-nav class="ml-auto">
                        <b-navbar-nav>
                            <b-nav-item :href="siteConfig.about" target="_blank">About</b-nav-item>
                        </b-navbar-nav>
                    </b-navbar-nav>
                </b-collapse>
            </div>
        </b-navbar>

        <b-jumbotron>
            <div class="container">
                <h1>{{siteConfig.title}}</h1>
                <p>{{siteConfig.info}}</p>
            </div>
        </b-jumbotron>
        <div class="content px-4">
            <div class="container">
                <div class="container">
                    <div class="row">
                        <div class="col-sm-8">
                            <blogList></blogList>
                        </div>
                        <div class="col-sm-4">
                            <div class="container">
                                <div class="row">
                                    <div class="col">
                                        <div class="card">
                                            <img src="../Resource/photo.jpg" class="card-img-top">
                                            <div class="card-body">
                                                <h5 class="card-title">{{siteConfig.userName}}</h5>
                                                <p class="card-text">{{siteConfig.userInfo}}</p>
                                                <a :href="siteConfig.gitHub" v-show="siteConfig.gitHub!=''" class="btn btn-outline-info" target="_blank">Fork Me On GitHub</a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="w-100" style="height:10px"></div>
                                    <div class="col">
                                        <b-list-group>
                                            <b-list-group-item href="javascript:void(0);" v-for="category in categoryList">{{category.name}}</b-list-group-item><!--active-->
                                        </b-list-group>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script lang="ts">
    import { Component, Vue, Inject, Prop, Watch } from 'vue-property-decorator';
    import blogList from './Blogs.vue';

    @Component({
        components: { blogList }
    })
    export default class Home extends Vue {
        get siteConfig() {
            return this.$store.state.SiteConfig.siteConfigInfo;
        }

        get categoryList() {
            return this.$store.state.Category.list;
        }

        async created() {
            await this.$store.dispatch('getSiteConfig');
            await this.$store.dispatch('Category/getAll');
        }
    }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
