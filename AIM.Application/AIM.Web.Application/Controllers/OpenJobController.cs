using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AIM.Application.Service.Entities.Models;
using AIM.Web.Application.JobServiceReference;

namespace AIM.Web.Application.Controllers
{
    public class OpenJobController : Controller
    {
        private JobServiceClient _client = new JobServiceClient();

        // GET: /OpenJob/
        public ActionResult Index(string RegionId)
        {
            int id = Convert.ToInt32(RegionId);

            ViewBag.RegionName = _client.GetRegionName(id);
            var openJobs = _client.GetOpenJobsList(id);
            return View(openJobs);
        }

        // GET: /OpenJob/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OpenJob openjob = _client.GetOpenJob(id);
            if (openjob == null)
            {
                return HttpNotFound();
            }

            ViewBag.Position = openjob.Job.position;
            return View(openjob);
        }

        public ActionResult Questionnaire()
        {
            return View();
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //OpenJob openjob = _client.GetOpenJob(id);
            //if (openjob == null)
            //{
            //    return HttpNotFound();
            //}

            //ViewBag.Position = openjob.Job.position;
            //return View(openjob);
        }

     
    }
}
