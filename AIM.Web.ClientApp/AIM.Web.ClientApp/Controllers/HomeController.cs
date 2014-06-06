using AIM.Web.Application.Client;
using System.Web.Mvc;

namespace AIM.Web.ClientApp.Controllers
{
    public class HomeController : Controller
    {
        readonly RegionServiceClient _regionClient = new RegionServiceClient();

        public ActionResult Index()
        {
            var regions = _regionClient.GetRegions();
            return View(regions);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}