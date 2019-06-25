using System.Threading.Tasks;

namespace SeaBlog.Blazor.Admin.Api.IApis
{
    public interface ISiteConfigApi
    {
        Task<JsonPackage<SiteConfig>> GetConfigAsync();
    }
}
