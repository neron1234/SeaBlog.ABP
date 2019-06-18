using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SeaBlog.Controllers
{
    public abstract class SeaBlogControllerBase: AbpController
    {
        protected SeaBlogControllerBase()
        {
            LocalizationSourceName = SeaBlogConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
