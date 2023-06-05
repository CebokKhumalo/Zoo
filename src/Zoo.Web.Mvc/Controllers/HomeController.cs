using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Zoo.Controllers;

namespace Zoo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ZooControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
