using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AFX.Controllers
{
    public abstract class AFXControllerBase: AbpController
    {
        protected AFXControllerBase()
        {
            LocalizationSourceName = AFXConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
