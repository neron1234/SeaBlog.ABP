﻿using Microsoft.AspNetCore.Components;
using SeaBlog.Blazor.Admin.Api.IApis;
using SeaBlog.Blazor.Admin.Models;
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

        public async Task<ListResult<BlogDetail>> GetPageAsync(BlogSearchParameters searchParameters)
        {
            ListResult<BlogDetail> result = new ListResult<BlogDetail>();
            try
            {
                result = await httpClient.GetJsonAsync<ListResult<BlogDetail>>($"{Config.ApiUrl}/api/services/app/Blog/GetAll?SkipCount={(searchParameters.PageIndex - 1) * Config.PageSize}&MaxResultCount={Config.PageSize}&categoryId={searchParameters.CategoryId}&Keyword={searchParameters.KeyWord}");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Error = ex.Message;
            }
            return result;
        }

        public async Task<EntityResult<BlogDetail>> GetDetailAsync(string id)
        {
            EntityResult<BlogDetail> result = new EntityResult<BlogDetail>();
            try
            {
                result = await httpClient.GetJsonAsync<EntityResult<BlogDetail>>($"{Config.ApiUrl}/api/services/app/Blog/Get?Id={id}");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Error = ex.Message;
            }
            return result;
        }

        public async Task<EntityResult<string>> CreateAsync(BlogDetail blogDetail)
        {
            EntityResult<string> result = new EntityResult<string>();
            try
            {
                result = await httpClient.PostJsonAsync<EntityResult<string>>($"{Config.ApiUrl}/api/services/app/Blog/Create", blogDetail);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Error = ex.Message;
            }
            return result;
        }
    }
}
