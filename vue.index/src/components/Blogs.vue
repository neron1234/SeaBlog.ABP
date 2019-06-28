<template>
    <div>
        <div class="card" style="margin-bottom:10px" v-for="blog in blogList">
            <h5 class="card-header">{{blog.creationTime}}</h5>
            <div class="card-body">
                <h5 class="card-title"><a href="javascript:void(0);" @click="showBlogDetail(blog.id)">{{blog.title}}</a></h5>
                <p class="card-text">{{blog.summary}}</p>
                <span class="badge badge-pill badge-info" v-for="categoryItem in blog.blogCategories">{{categoryItem.category.name}}</span>
            </div>
        </div>
        <b-pagination v-model="currentPage" :total-rows="totalCount" :per-page="pageSize"></b-pagination>
    </div>
</template>

<script lang="ts">
    import { Component, Vue, Inject, Prop, Watch } from 'vue-property-decorator';
    import PageRequest from '@/store/entities/page-request'

    class PageBlogRequest extends PageRequest {
        keyword!: string;
        categoryId!: string;
        isShow!: boolean;
    }

    class BlogDetailRequest {
        id!: string;
    }

    @Component
    export default class Blogs extends Vue {
        pagerequest: PageBlogRequest = new PageBlogRequest();
        detailrequest: BlogDetailRequest = new BlogDetailRequest();

        get blogList() {
            return this.$store.state.Blog.list;
        }

        get loading() {
            return this.$store.state.Blog.loading;
        }

        get currentPage() {
            return this.$store.state.Blog.currentPage;
        }

        set currentPage(value: number) {
            this.$store.state.Blog.currentPage = value;
            this.getBlogs();
        }

        get totalCount(){
            return this.$store.state.Blog.totalCount;
        }

        get pageSize() {
            return this.$store.state.Blog.pageSize;
        }

        async showBlogDetail(id: string) {
            this.$store.commit('Blog/setShowList', false);
            this.$store.commit('Blog/setShowDetail', true);
            this.detailrequest.id = id;
            await this.$store.dispatch({
                type: 'Blog/getDetail',
                data: this.detailrequest
            });
        }

        async getBlogs() {
            this.pagerequest.skipCount = (this.currentPage - 1) * this.pageSize;
            this.pagerequest.maxResultCount = this.pageSize;
            this.pagerequest.keyword = this.$store.state.Blog.keyWord;
            this.pagerequest.categoryId = this.$store.state.Blog.categoryId;

            await this.$store.dispatch({
                type: 'Blog/getPage',
                data: this.pagerequest
            });
        }

        async created() {
            this.getBlogs();
        }
    }
</script>

<style scoped>
</style>