using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Majales.Controllers
{
    public abstract class MajalesControllerBase: AbpController
    {
        protected MajalesControllerBase()
        {
            LocalizationSourceName = MajalesConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
