using Abp.AspNetCore.Mvc.ViewComponents;

namespace Zoo.Web.Views
{
    public abstract class ZooViewComponent : AbpViewComponent
    {
        protected ZooViewComponent()
        {
            LocalizationSourceName = ZooConsts.LocalizationSourceName;
        }
    }
}
