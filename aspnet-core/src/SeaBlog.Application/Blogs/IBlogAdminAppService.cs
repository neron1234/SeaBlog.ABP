using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using SeaBlog.Blogs.Dto;

namespace SeaBlog.Blogs
{
    public interface IBlogAdminAppService : IApplicationService
    {
        Task<BlogPageOutput> GetPageAsync(BlogSearchInput input);
    }
}
