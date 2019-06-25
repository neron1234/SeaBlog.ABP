using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SeaBlog.Blazor.Admin.Api.Apis
{
    public class SiteConfigApi : ISiteConfigApi
    {
        private readonly HttpClient httpClient;

        public SiteConfigApi(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<JsonPackage<SiteConfig>> GetConfigAsync()
        {
            JsonPackage<SiteConfig> siteConfig = new JsonPackage<SiteConfig>();
            try
            {
                siteConfig = await httpClient.GetJsonAsync<JsonPackage<SiteConfig>>("api/SiteConfig/Get");
            }
            catch (Exception ex)
            {
                siteConfig.Success = false;
                siteConfig.Message = ex.Message;
            }
            return siteConfig;
        }
    }
}
