using Abp.Application.Services;
using SeaBlog.Blogs.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SeaBlog.Blogs
{
    public interface IBlogAppService : IApplicationService
    {
        Task<BlogPageOutput> GetPageAsync(BlogSearchInput input);
    }
}
