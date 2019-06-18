using Abp.EntityFrameworkCore;
using SeaBlog.BlogEntitys;
using SeaBlog.EntityFrameworkCore;
using SeaBlog.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Repositories
{
    public class BlogRepository : SeaBlogRepositoryBase<Blog, Guid>, IBlogRepository
    {
        public BlogRepository(IDbContextProvider<SeaBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
