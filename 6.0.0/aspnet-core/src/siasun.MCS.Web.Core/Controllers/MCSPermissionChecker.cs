using Abp;
using Abp.Authorization;
using Abp.Runtime.Session;
using System.Threading.Tasks;

namespace siasun.MCS.Controllers
{
    public class MCSPermissionChecker 
    {
        private IAbpSession session;

        public MCSPermissionChecker(IAbpSession _session)
        {
            session = _session;
        }

        public Task<bool> IsGrantedAsync(string permissionName)
        {
            var uid = session.UserId;
            //throw new NotImplementedException();
            return Task.FromResult(true);
        }

        public Task<bool> IsGrantedAsync(UserIdentifier user, string permissionName)
        {

            //throw new NotImplementedException();
            return Task.FromResult(true);
        }
    }
}
