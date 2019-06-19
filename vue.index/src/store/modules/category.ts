import { Store, Module, ActionContext } from 'vuex'
import ListState from "./list-state";
import Category from "../entities/category"
import ListModule from './list-module';
import Ajax from '../../lib/ajax'

interface CategoryState extends ListState<Category> {

}

class CategoryModule extends ListModule<CategoryState, any, Category>{
    state = {
        totalCount: 0,
        currentPage: 1,
        pageSize: 10,
        list: new Array<Category>(),
        loading: false
    }
    actions = {
        async getAll(context: ActionContext<CategoryState, any>) {
            context.state.loading = true;
            let reponse = await Ajax.get('/api/services/app/Category/GetListAsync');
            context.state.loading = false;
            context.state.list = reponse.data.result;
        }
    }
}

const categoryModule = new CategoryModule();
export default categoryModule;