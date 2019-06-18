using System.Threading.Tasks;
using Abp.Application.Services;
using SeaBlog.Authorization.Accounts.Dto;

namespace SeaBlog.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
