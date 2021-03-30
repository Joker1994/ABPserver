using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace siasun.MCS.Controllers
{
    public abstract class MCSControllerBase: AbpController
    {
        protected MCSControllerBase()
        {
            LocalizationSourceName = MCSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
