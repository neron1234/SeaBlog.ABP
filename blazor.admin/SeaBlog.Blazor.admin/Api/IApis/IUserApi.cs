using SeaBlog.Blazor.Admin.Models;
using System.Threading.Tasks;

namespace SeaBlog.Blazor.Admin.Api.IApis
{
    public interface IUserApi
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<EntityResult<UserDetail>> LoginAsync(LoginParameters parameters);

        /// <summary>
        /// 判断是否登录
        /// </summary>
        /// <returns></returns>
        Task<bool> IsLoginAsync();

        /// <summary>
        /// 获取登录用户信息
        /// </summary>
        /// <returns></returns>
        Task<EntityResult<UserDetail>> GetUserInfoAsync();

        /// <summary>
        /// 登出
        /// </summary>
        /// <returns></returns>
        Task<EntityResult<string>> LoginOutAsync();
    }
}
