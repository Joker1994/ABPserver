using System.Threading.Tasks;
using Abp.Application.Services;
using siasun.MCS.Authorization.Accounts.Dto;

namespace siasun.MCS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
