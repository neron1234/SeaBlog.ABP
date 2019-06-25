using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SeaBlog.Blazor.Admin.Api.Apis
{
    public class BlogApi : IBlogApi
    {
        private readonly HttpClient httpClient;

        public BlogApi(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<JsonPackage<(int pageCount, IList<BlogDetail> blogs)>> GetPageAsync(BlogSearchParameters searchParameters)
        {
            JsonPackage<(int pageCount, IList<BlogDetail> blogs)> result = new JsonPackage<(int pageCount, IList<BlogDetail> blogs)>();
            try
            {
                result = await httpClient.GetJsonAsync<JsonPackage<(int pageCount, IList<BlogDetail> blogs)>>($"api/Blog/GetList?pageIndex={searchParameters.PageIndex}&categoryId={searchParameters.CategoryId}&KeyWord={searchParameters.KeyWord}");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }

        public async Task<JsonPackage<BlogDetail>> GetDetailAsync(string id)
        {
            JsonPackage<BlogDetail> result = new JsonPackage<BlogDetail>();
            try
            {
                result = await httpClient.GetJsonAsync<JsonPackage<BlogDetail>>($"api/Blog/GetDetail?id={id}");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }

        public async Task<JsonPackage<BlogDetail>> GetOperDetailAsync(string id)
        {
            JsonPackage<BlogDetail> result = new JsonPackage<BlogDetail>();
            try
            {
                result = await httpClient.GetJsonAsync<JsonPackage<BlogDetail>>($"api/Blog/GetOperDetail?id={id}");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }

        public async Task<JsonPackage<string>> SaveAsync(BlogDetail blogDetail)
        {
            JsonPackage<string> result = new JsonPackage<string>();
            try
            {
                result = await httpClient.PostJsonAsync<JsonPackage<string>>("api/Blog/Save", blogDetail);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}
