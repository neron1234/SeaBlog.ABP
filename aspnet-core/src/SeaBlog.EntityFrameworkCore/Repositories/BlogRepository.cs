using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SeaBlog.BlogEntitys;
using SeaBlog.EntityFrameworkCore;
using SeaBlog.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeaBlog.Util;

namespace SeaBlog.Repositories
{
    public class BlogRepository : SeaBlogRepositoryBase<Blog, Guid>, IBlogRepository
    {
        public BlogRepository(IDbContextProvider<SeaBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<(int pageCount, List<Blog> blogs)> GetPageAsync(int pageIndex, int pageSize)
        {
            var query = GetAll()
                    .Include(b => b.BlogCategories)
                    .ThenInclude(b => b.Category)
                    .Where(b => b.IsShow == true && b.IsDeleted == false);
            //if (!string.IsNullOrEmpty(categoryId))
            //    query = query.Where(b => b.BlogCategories.Select(bc => bc.CategoryID).Contains(categoryId));
            //if (!string.IsNullOrEmpty(keyWrod))
            //    query = query.Where(b => b.Title.Contains(keyWrod) || b.Summary.Contains(keyWrod));
            var list = await query
                .OrderByDescending(b => b.CreationTime)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            int pageCount = query.PageCount(pageSize);
            return (pageCount, list);
        }
    }
}
