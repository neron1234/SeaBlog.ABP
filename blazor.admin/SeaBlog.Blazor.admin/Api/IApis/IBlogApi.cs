using System.Collections.Generic;
using System.Threading.Tasks;

namespace SeaBlog.Blazor.Admin.Api.IApis
{
    public interface IBlogApi
    {
        /// <summary>
        /// 获取博客列表
        /// </summary>
        /// <param name="searchParameters"></param>
        /// <returns></returns>
        Task<JsonPackage<(int pageCount, IList<BlogDetail> blogs)>> GetPageAsync(BlogSearchParameters searchParameters);

        /// <summary>
        /// 获取博客详细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<JsonPackage<BlogDetail>> GetDetailAsync(string id);

        /// <summary>
        /// 编辑博客
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<JsonPackage<BlogDetail>> GetOperDetailAsync(string id);

        /// <summary>
        /// 保存博客
        /// </summary>
        /// <param name="blogDetail"></param>
        /// <returns></returns>
        Task<JsonPackage<string>> SaveAsync(BlogDetail blogDetail);
    }
}
