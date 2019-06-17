using System.Threading.Tasks;
using Abp.Application.Services;
using Majales.Authorization.Accounts.Dto;

namespace Majales.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
