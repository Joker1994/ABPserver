using System.Threading.Tasks;
using Abp.Application.Services;
using siasun.MCS.Sessions.Dto;

namespace siasun.MCS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
