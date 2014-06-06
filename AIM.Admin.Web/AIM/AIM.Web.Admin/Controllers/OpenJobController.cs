using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using AIM.Web.Admin.Client;
using AIM.Web.Admin.Models.EntityModels;
using AIM.Web.ClientApp.Client;

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


        // public async Task<ViewResult> StoreSelect(string RegionID)
        public ViewResult StoreSelect(string RegionID)
        {
            int id = Convert.ToInt32(RegionID);

            IEnumerable<Store> stores = getDummyStoreData(id);

            //using (var client = new StoreServiceClient())
            //{
            //    stores = await client.GetStoresByRegionId(id);
            //}

            return View(stores.ToList());
        }
        

        public ViewResult OpenJobList(string StoreId)
        //public async Task<ViewResult> OpenJobList(string StoreId)
        {
            int id = Convert.ToInt32(StoreId);

            IEnumerable<OpenJob> jobs = null;
            jobs = getDummyOpenJobData(id);

            //using (var client = new OpenJobServiceClient())
            //{
            //    jobs = await client.GetOpenJobsByStoreId(id);
            //}

            return View(jobs);
        }


        private Store[] getDummyStoreData(int region)
        {
            Store[] storeArray = new Store[5];
            for (int i = 0; i < 5; ++i)
            {
                storeArray[i] = new Store();
                storeArray[i].Name = "Some Store " + i.ToString();
                storeArray[i].StoreId = i;
                storeArray[i].RegionId = region;
            }

            return storeArray;
        }


        private OpenJob[] getDummyOpenJobData(int store)
        {
            Job job1 = new Job();
            job1.Position = "Cashier";
            job1.JobId = 45;

            Job job2 = new Job();
            job2.Position = "Store Clerk";
            job2.JobId = 43;

            Store store2 = new Store();
            store2.Name = "A Cool Store";
            store2.StoreId = 23;

            OpenJob[] array = new OpenJob[5];
            for(int i = 0; i < 5; ++i)
            {
                array[i] = new OpenJob();
                array[i].OpenJobsId = i;
                array[i].Store = store2;
                array[i].StoreId = store2.StoreId;
                array[i].IsApproved = false;

                if (i % 2 == 1)
                    array[i].Job = job1;

                else
                    array[i].Job = job2;
            }

            array[1].IsApproved = true;
            array[4].IsApproved = true;

            return array;
        }


        //
        // GET: /OpenJob/Details/5
        public async Task<ViewResult> Details(int id)
        {
            OpenJob job = null;
            using(var client = new OpenJobServiceClient())
            {
                job = await client.GetOpenJobById(id);
            }

            return View(job);
        }



        //
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


            var IDQuery = from i in jobs select i.JobId;
           
            

            return View();
        }

        //
        // POST: /OpenJob/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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

        ////
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
            using (var client = new OpenJobServiceClient())
            {
                await client.DeleteOpenJob(id);
            }

            return RedirectToAction("Index");
        }
    }
}
