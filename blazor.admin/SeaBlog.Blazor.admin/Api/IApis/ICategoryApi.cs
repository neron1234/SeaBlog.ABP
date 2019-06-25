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
        Task<JsonPackage<IList<CategoryDetail>>> GetListAsync();

        /// <summary>
        /// 获取分类分页
        /// </summary>
        /// <param name="searchParameters"></param>
        /// <returns></returns>
        Task<JsonPackage<(int pageCount, IList<CategoryDetail> categorys)>> GetPageAsync(CommonSearchParameters searchParameters);

        /// <summary>
        /// 编辑分类
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<JsonPackage<CategoryDetail>> GetDetailAsync(string id);

        /// <summary>
        /// 保存分类
        /// </summary>
        /// <param name="CategoryDetail"></param>
        /// <returns></returns>
        Task<JsonPackage<string>> SaveAsync(CategoryDetail blogDetail);
    }
}
