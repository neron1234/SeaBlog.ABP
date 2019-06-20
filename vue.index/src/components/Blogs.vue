<template>
    <div>
        <div class="card" style="margin-bottom:10px" v-for="blog in blogList">
            <h5 class="card-header">{{blog.creationTime}}</h5>
            <div class="card-body">
                <h5 class="card-title"><a :href="blog.id">{{blog.title}}</a></h5>
                <p class="card-text">{{blog.summary}}</p>
                <span class="badge badge-pill badge-info">@c.Name</span>
            </div>
        </div>
    </div>
</template>

<script lang="ts">
    import { Component, Vue, Inject, Prop, Watch } from 'vue-property-decorator';
    import PageRequest from '@/store/entities/page-request'

    class PageBlogRequest extends PageRequest {
        keyword!: string;
        categoryId!: string;
    }

    @Component
    export default class Blogs extends Vue {
        @Prop({ type: String, default: "" }) keyWord!: string;
        @Prop({ type: String, default: "" }) categoryId!: string;

        pagerequest: PageBlogRequest = new PageBlogRequest();

        get blogList() {
            return this.$store.state.Blog.list;
        }

        get loading() {
            return this.$store.state.Blog.loading;
        }

        get currentPage() {
            return this.$store.state.Blog.currentPage;
        }

        get pageSize() {
            return this.$store.state.Blog.pageSize;
        }

        async getBlogs() {
            this.pagerequest.skipCount = (this.currentPage - 1) * this.pageSize;
            this.pagerequest.maxResultCount = this.pageSize;
            this.pagerequest.keyword = this.keyWord;
            this.pagerequest.categoryId = this.categoryId;

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