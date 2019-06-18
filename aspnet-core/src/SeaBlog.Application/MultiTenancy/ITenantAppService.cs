using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SeaBlog.MultiTenancy.Dto;

namespace SeaBlog.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

