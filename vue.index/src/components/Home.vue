<template>
    <div class="home">
        <h1>Welcome to {{ msg }}</h1>
        <p>这是一个关于.NET和健身的博客...</p>
    </div>
</template>

<script lang="ts">
    import { Component, Prop, Vue } from 'vue-property-decorator';

    @Component
    export default class Home extends Vue {
        @Prop() private msg!: string;
    }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
