using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;
using AIM.Web.Admin.Client;
using AIM.Web.Admin.Models.EntityModels;

namespace AIM.Web.Admin.Controllers
{
    public class OpenJobController : Controller
    {
        //
        // GET: /OpenJob/
        public async Task<ViewResult> Index()
        {
            IEnumerable<Region> regions = null;

            using (var client = new RegionServiceClient())
            {
                regions = await client.GetRegions();
            }

            return View(regions);
        }


        public async Task<ViewResult> StoreSelect(string RegionID)
        {
            int regionId = Convert.ToInt32(RegionID);

            IEnumerable<Store> stores = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://aimadminstrativeservice.cloudapp.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                string request = "api/Store?regionId=" + regionId;
                HttpResponseMessage response = await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    stores = await response.Content.ReadAsAsync<IEnumerable<Store>>();
                }
            }

            return View(stores);
        }


        public async Task<ViewResult> OpenJobList(string StoreId)
        {
            int storeId = Convert.ToInt32(StoreId);

            IEnumerable<OpenJob> jobs = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://aimadminstrativeservice.cloudapp.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                string request = "api/OpenJob?storeId=" + storeId;
                HttpResponseMessage response = await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    jobs = await response.Content.ReadAsAsync<IEnumerable<OpenJob>>();
                }
            }

            return View(jobs);
        }
     
        
        // GET: /OpenJob/Details/5
        public async Task<ViewResult> Details(int jobid)
        {
            OpenJob job = null;
            using(var client = new OpenJobServiceClient())
            {
                job = await client.GetOpenJobById(jobid);
            }

            ViewBag.Approved = job.IsApproved;
            ViewBag.OpenJobId = job.OpenJobsId;

            return View(job);
        }

        
        // GET: /OpenJob/Create
        public async Task<ActionResult> Create()
        {
            IEnumerable<Job> jobs = null;
            using(var client = new JobServiceClient())
            {
                jobs = await client.GetJobs();
            }

            var TitleList = new List<string>();
            var TitlesQuery = from j in jobs select j.Position;

            TitleList.AddRange(TitlesQuery);
            var sl = new SelectList(TitleList);
            
            ViewBag.JobTitles = sl;
            ViewBag.Jobs = jobs;

            return View();
        }


        // POST: /OpenJob/Create
        [HttpPost]
        public async Task<ActionResult> Create([Bind(Include = "JobId,StoreId,RegionId")] OpenJob openjob)
        {
            openjob.IsApproved = false;
            try
            {
                using(var client = new OpenJobServiceClient())
                {
                   await client.CreateOpenJob(openjob);
                }
                return RedirectToAction("Details", openjob.OpenJobsId);
            }
            catch (Exception e)
            {
                ViewBag.Message = e.ToString();
                return View("Error");
            }
        }


        public async Task<ActionResult> ApproveOpening(int id)
        {
            await Approve(id);
            return RedirectToAction("Details", id);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Approve(int openjobid)
        {
            OpenJob job = null;
            using(var client = new OpenJobServiceClient() )
            {
                job = await client.GetOpenJobById(openjobid);
                job.IsApproved = true;
                await client.EditOpenJob(job);
            }
            return View("Details", job.OpenJobsId);
        }


        public async Task<ActionResult> Delete(int? id)
        {
            OpenJob job = null;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            using (var client = new OpenJobServiceClient())
            {
                job = await client.GetOpenJobById(id);
            }

            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // POST: /Job/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            OpenJob temp = null;
            int store = 0;

            using (var client = new OpenJobServiceClient())
            {
                temp = await client.GetOpenJobById(id);
                store = temp.StoreId;

                await client.DeleteOpenJob(id);
            }

            return RedirectToAction("OpenJobList", store);
        }



        ////
        //// GET: /OpenJob/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        ////
        //// POST: /OpenJob/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        ////
        //// GET: /OpenJob/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}
    }
}
