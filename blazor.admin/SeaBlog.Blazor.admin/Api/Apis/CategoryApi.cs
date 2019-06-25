using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SeaBlog.Blazor.Admin.Api.Apis
{
    public class CategoryApi : ICategoryApi
    {
        private readonly HttpClient httpClient;

        public CategoryApi(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<JsonPackage<IList<CategoryDetail>>> GetListAsync()
        {
            JsonPackage<IList<CategoryDetail>> result = new JsonPackage<IList<CategoryDetail>>();
            try
            {
                result = await httpClient.GetJsonAsync<JsonPackage<IList<CategoryDetail>>>("api/Category/GetList");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }

        public async Task<JsonPackage<(int pageCount, IList<CategoryDetail> categorys)>> GetPageAsync(CommonSearchParameters searchParameters)
        {
            JsonPackage<(int pageCount, IList<CategoryDetail> blogs)> result = new JsonPackage<(int pageCount, IList<CategoryDetail> blogs)>();
            try
            {
                result = await httpClient.GetJsonAsync<JsonPackage<(int pageCount, IList<CategoryDetail> blogs)>>($"api/Category/GetPage?pageIndex={searchParameters.PageIndex}&KeyWord={searchParameters.KeyWord}");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }

        public async Task<JsonPackage<CategoryDetail>> GetDetailAsync(string id)
        {
            JsonPackage<CategoryDetail> result = new JsonPackage<CategoryDetail>();
            try
            {
                result = await httpClient.GetJsonAsync<JsonPackage<CategoryDetail>>($"api/Category/GetDetail?id={id}");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
            }
            return result;
        }

        public async Task<JsonPackage<string>> SaveAsync(CategoryDetail categoryDetail)
        {
            JsonPackage<string> result = new JsonPackage<string>();
            try
            {
                result = await httpClient.PostJsonAsync<JsonPackage<string>>("api/Category/Save", categoryDetail);
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
