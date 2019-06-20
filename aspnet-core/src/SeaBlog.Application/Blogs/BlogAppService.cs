using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using SeaBlog.Blogs.Dto;
using SeaBlog.Configuration;
using SeaBlog.Repositories;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SeaBlog.Blogs
{
    public class BlogAppService : SeaBlogAppServiceBase, IBlogAppService
    {
        private readonly IBlogRepository _blogRepository;

        public BlogAppService(IBlogRepository blogRepository)
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
                //if (!string.IsNullOrEmpty(categoryId))
                //    query = query.Where(b => b.BlogCategories.Select(bc => bc.CategoryID).Contains(categoryId));
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
