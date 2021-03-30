using Abp.Application.Services;
using siasun.MCS.MultiTenancy.Dto;

namespace siasun.MCS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

