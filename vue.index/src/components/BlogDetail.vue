<template>
    <div>
        <b-card :title="blogDetail.title" :sub-title="blogDetail.creationTime">
            <b-card-text v-html="blogDetail.htmlContent" v-highlight></b-card-text>
            <b-button variant="outline-primary" @click="back()">Back</b-button>
        </b-card>
    </div>
</template>

<script lang="ts">
    import { Component, Vue, Inject, Prop, Watch } from 'vue-property-decorator';

    @Component
    export default class BlogDetail extends Vue {
        get blogDetail() {
            return this.$store.state.Blog.blogDetail;
        }

        back() {
            this.$store.commit('Blog/setShowList', true);
            this.$store.commit('Blog/setShowDetail', false);
        }
    }
</script>

<style scoped>
</style>