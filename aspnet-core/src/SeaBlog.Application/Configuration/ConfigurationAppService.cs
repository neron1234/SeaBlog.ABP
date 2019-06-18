using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SeaBlog.Configuration.Dto;

namespace SeaBlog.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SeaBlogAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
