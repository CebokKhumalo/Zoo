using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Zoo.Web.Views
{
    public abstract class ZooRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ZooRazorPage()
        {
            LocalizationSourceName = ZooConsts.LocalizationSourceName;
        }
    }
}
