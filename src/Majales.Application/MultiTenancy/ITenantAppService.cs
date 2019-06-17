using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Majales.MultiTenancy.Dto;

namespace Majales.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

