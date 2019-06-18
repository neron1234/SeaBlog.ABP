using Abp.EntityFrameworkCore;
using SeaBlog.BlogEntitys;
using SeaBlog.EntityFrameworkCore;
using SeaBlog.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Repositories
{
    public class CategoryRepository : SeaBlogRepositoryBase<Category, Guid>, ICategoryRepository
    {
        public CategoryRepository(IDbContextProvider<SeaBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
