using System.Threading.Tasks;
using SeaBlog.Configuration.Dto;

namespace SeaBlog.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
