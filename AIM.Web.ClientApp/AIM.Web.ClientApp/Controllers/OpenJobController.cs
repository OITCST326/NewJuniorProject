using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AIM.Web.Application.Client;
using AIM.Web.ClientApp.Client;
using AIM.Web.ClientApp.Models.EntityModels;

namespace AIM.Web.ClientApp.Controllers
{
    public class OpenJobController : Controller
    {
        private readonly JobServiceClient _jobClient = new JobServiceClient();
        private readonly OpenJobServiceClient _openJobClient = new OpenJobServiceClient();
        private readonly RegionServiceClient _regionClient = new RegionServiceClient();

        // GET: /OpenJob/
        public async Task<ViewResult> Index(string regionId)
        {
            int id = Convert.ToInt32(regionId);

            ViewBag.RegionName = await _regionClient.GetRegionById(id);
            var openJobs = await _openJobClient.GetOpenJobs();
            return View(openJobs);
        }

        // GET: /OpenJob/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OpenJob openjob = await _openJobClient.GetOpenJobById(id);
            if (openjob == null)
            {
                return HttpNotFound();
            }

            ViewBag.Position = openjob.Job.Position;
            return View(openjob);
        }

     
    }
}
