using SeaBlog.Blazor.Admin.Models;
using SeaBlog.Blazor.Admin.Models.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SeaBlog.Blazor.Admin.Api.IApis
{
    public interface ICategoryApi
    {
        /// <summary>
        /// 获取全部分类列表
        /// </summary>
        /// <returns></returns>
        Task<ListResult<CategoryDetail>> GetListAsync();

        /// <summary>
        /// 获取分类分页
        /// </summary>
        /// <param name="searchParameters"></param>
        /// <returns></returns>
        Task<ListResult<CategoryDetail>> GetPageAsync(SearchParameters searchParameters);

        /// <summary>
        /// 获取分类详细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<EntityResult<CategoryDetail>> GetDetailAsync(string id);

        /// <summary>
        /// 保存分类
        /// </summary>
        /// <param name="CategoryDetail"></param>
        /// <returns></returns>
        Task<EntityResult<string>> SaveAsync(CategoryDetail categoryDetail);
    }
}
