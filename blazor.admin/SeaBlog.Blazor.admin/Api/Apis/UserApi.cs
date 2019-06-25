using Microsoft.AspNetCore.Components;
using SeaBlog.Blazor.Admin.Api.IApis;
using SeaBlog.Blazor.Admin.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SeaBlog.Blazor.Admin.Api.Apis
{
    public class UserApi : IUserApi
    {
        private readonly HttpClient httpClient;

        public UserApi(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<EntityResult<UserDetail>> LoginAsync(LoginParameters parameters)
        {
            EntityResult<UserDetail> result = new EntityResult<UserDetail>();
            try
            {
                result = await httpClient.PostJsonAsync<EntityResult<UserDetail>>($"{Config.ApiUrl}/api/TokenAuth/Authenticate", parameters);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Error = ex.Message;
            }
            return result;
        }

        public async Task<bool> IsLoginAsync()
        {
            var userInfo = await GetUserInfoAsync();
            return userInfo.Success;
        }

        public async Task<EntityResult<UserDetail>> GetUserInfoAsync()
        {
            EntityResult<UserDetail> userInfo = new EntityResult<UserDetail>();
            try
            {
                userInfo = await httpClient.GetJsonAsync<EntityResult<UserDetail>>($"{Config.ApiUrl}api/Authorize/GetUserInfo");
            }
            catch (Exception ex)
            {
                userInfo.Success = false;
                userInfo.Error = ex.Message;
            }
            return userInfo;
        }

        public async Task<EntityResult<string>> LoginOutAsync()
        {
            EntityResult<string> result = new EntityResult<string>();
            try
            {
                result = await httpClient.PostJsonAsync<EntityResult<string>>($"{Config.ApiUrl}api/Authorize/LoginOut", null);
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
