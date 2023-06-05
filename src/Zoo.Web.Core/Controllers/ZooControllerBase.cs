using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Zoo.Controllers
{
    public abstract class ZooControllerBase: AbpController
    {
        protected ZooControllerBase()
        {
            LocalizationSourceName = ZooConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
