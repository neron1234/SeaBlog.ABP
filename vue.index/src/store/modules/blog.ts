import ListState from "./list-state";
import Blog from '../entities/Blog';
import ListModule from './list-module';
import { ActionContext } from 'vuex';
import Ajax from '../../lib/ajax';
import PageResult from '../entities/page-result';

interface BlogState extends ListState<Blog> {

}

class BlogModule extends ListModule<BlogState, any, Blog>{
    state = {
        totalCount: 0,
        currentPage: 1,
        pageSize: 10,
        list: new Array<Blog>(),
        loading: false,
    }
    actions = {
        async getPage(context: ActionContext<BlogState, any>, payload: any) {
            context.state.loading = true;
            let reponse = await Ajax.get('/api/services/app/Blog/GetPageAsync', { params: payload.data });
            context.state.loading = false;
            let page = reponse.data.result as PageResult<Blog>;
            context.state.totalCount = page.totalCount;
            context.state.list = page.items;
        }
    }
}

const blogModule = new BlogModule();
export default blogModule;