import { Store, Module, ActionContext } from 'vuex'
import Ajax from '../../lib/ajax'
import siteConfig from '../entities/siteConfig'
interface SiteConfigState {
    siteConfigInfo: siteConfig
}
class SiteConfigModule implements Module<SiteConfigState, any>{
    state = {
        siteConfigInfo: new siteConfig()
    }
    actions = {
        async getSiteConfig(context: ActionContext<SiteConfigState, any>) {
            let reponse = await Ajax.get('/api/services/app/SiteConfig/GetSiteConfig');
            context.state.siteConfigInfo = reponse.data.result;
        }
    }
}
const siteConfigModule = new SiteConfigModule();
export default siteConfigModule;