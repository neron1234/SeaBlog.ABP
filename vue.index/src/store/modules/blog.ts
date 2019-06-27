import ListState from "./list-state";
import Blog from '../entities/Blog';
import ListModule from './list-module';
import { ActionContext } from 'vuex';
import Ajax from '../../lib/ajax';
import PageResult from '../entities/page-result';
import ListMutations from './list-mutations';

interface BlogState extends ListState<Blog> {
    keyWord: string,
    categoryId: string,
    showList: boolean,
    showDetail: boolean,
    blogDetail: Blog,
}

class BLogMutations extends ListMutations<Blog>{

}

class BlogModule extends ListModule<BlogState, any, Blog>{
    state = {
        keyWord: "",
        categoryId: "",
        totalCount: 0,
        currentPage: 1,
        pageSize: 10,
        list: new Array<Blog>(),
        loading: false,
        showList: true,
        showDetail: false,
        blogDetail: new Blog()
    }
    actions = {
        async getPage(context: ActionContext<BlogState, any>, payload: any) {
            context.state.loading = true;
            let reponse = await Ajax.get('/api/services/app/Blog/GetAll', { params: payload.data });
            context.state.loading = false;
            let page = reponse.data.result as PageResult<Blog>;
            context.state.totalCount = page.totalCount;
            context.state.list = page.items;
        },
        async getDetail(context: ActionContext<BlogState, any>, payload: any) {
            context.state.loading = true;
            let reponse = await Ajax.get('/api/services/app/Blog/Get', { params: payload.data });
            context.state.loading = false;
            let blogDetail = reponse.data.result as Blog;
            context.state.blogDetail = blogDetail;
        } 
    };
    mutations = {
        setCurrentPage(state: BlogState, page: number) {
            state.currentPage = page;
        },
        setPageSize(state: BlogState, pagesize: number) {
            state.pageSize = pagesize;
        },
        setKeyword(state: BlogState, keyWord: string) {
            state.keyWord = keyWord;
        },
        setCategoryId(state: BlogState, categoryId: string) {
            state.categoryId = categoryId;
        },
        setShowList(state: BlogState, showList: boolean) {
            state.showList = showList;
        },
        setShowDetail(state: BlogState, showDetail: boolean) {
            state.showDetail = showDetail;
        }
    }
}

const blogModule = new BlogModule();
export default blogModule;