using Abp.Authorization;
using Microsoft.EntityFrameworkCore;
using SeaBlog.Authorization;
using SeaBlog.Blogs.Dto;
using SeaBlog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBlog.Blogs
{
    [AbpAuthorize(PermissionNames.Pages_Blogs)]
    public class BlogAdminAppService : SeaBlogAppServiceBase, IBlogAdminAppService
    {
        private readonly IBlogRepository _blogRepository;

        public BlogAdminAppService(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<BlogPageOutput> GetPageAsync(BlogSearchInput input)
        {
            try
            {
                var query = _blogRepository.GetAll()
                    .Include(b => b.BlogCategories)
                    .ThenInclude(b => b.Category)
                    .Where(b => b.IsShow == true && b.IsDeleted == false);
                if (!string.IsNullOrEmpty(input.categoryId))
                    query = query.Where(b => b.BlogCategories.Select(bc => bc.CategoryID.ToString()).Contains(input.categoryId));
                if (!string.IsNullOrEmpty(input.Keyword))
                    query = query.Where(b => b.Title.Contains(input.Keyword) || b.Summary.Contains(input.Keyword));
                var list = await query
                    .OrderByDescending(b => b.CreationTime)
                    .Skip(input.SkipCount)
                    .Take(input.MaxResultCount)
                    .ToListAsync();
                var recordCount = await query.CountAsync();
                var output = ObjectMapper.Map<List<BlogDetailOutput>>(list);
                return new BlogPageOutput { TotalCount = recordCount, Items = output };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
