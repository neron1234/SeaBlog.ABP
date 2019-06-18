using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Options;
using SeaBlog.Blogs.Dto;
using SeaBlog.Configuration;
using SeaBlog.Repositories;

namespace SeaBlog.Blogs
{
    public class BlogAppService : SeaBlogAppServiceBase, IBlogAppService
    {
        private readonly IBlogRepository _blogRepository;
        private readonly SiteConfig _siteConfig;

        public BlogAppService(IBlogRepository blogRepository, IOptions<SiteConfig> siteConfig)
        {
            _blogRepository = blogRepository;
            _siteConfig = siteConfig.Value;
        }

        public async Task<BlogPageOutput> GetPageAsync(BlogSearchInput input)
        {
            try
            {
                int pageSize = _siteConfig.PageSize;
                var pageResult = await _blogRepository.GetPageAsync(input.PageIndex, pageSize);
                var list = Mapper.Map<List<BlogDetailOutput>>(pageResult.blogs);
                return new BlogPageOutput { PageCount = pageResult.pageCount, List = list };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
