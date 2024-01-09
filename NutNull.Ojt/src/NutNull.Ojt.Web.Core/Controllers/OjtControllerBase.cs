using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace NutNull.Ojt.Controllers
{
    public abstract class OjtControllerBase: AbpController
    {
        protected OjtControllerBase()
        {
            LocalizationSourceName = OjtConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
