using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Demo.TestEffortWithEfDynamicFilters.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TestEffortWithEfDynamicFiltersControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}