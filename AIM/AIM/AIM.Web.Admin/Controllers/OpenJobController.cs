using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AIM.Service.Entities.Models;
using AIM.Web.Admin.JobServiceReference;

namespace AIM.Web.Admin.Controllers
{
    public class OpenJobController : Controller
    {
        private JobServiceClient _client = new JobServiceClient();

        // GET: /OpenJob/
        public ActionResult Index()
        {
            var regions = _client.GetRegionList();
            return View(regions.ToList());
        }

        public ActionResult StoreSelect(string RegionId)
        {
            int id = Convert.ToInt32(RegionId);
            var stores = _client.GetStoreList(id);
            return View(stores.ToList());
        }

        public ActionResult OpenJobList(string StoreId)
        {
            int id = Convert.ToInt32(StoreId);
            var openJobs = _client.GetOpenJobsForStore(id);
            return View(openJobs.ToList());
        }



        // GET: /OpenJob/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OpenJob openjob = db.OpenJobs.Find(id);
            if (openjob == null)
            {
                return HttpNotFound();
            }
            return View(openjob);
        }

        /*
        // GET: /OpenJob/Create
        public ActionResult Create()
        {
            ViewBag.jobId = new SelectList(db.Jobs, "jobId", "position");
            ViewBag.regionId = new SelectList(db.Regions, "regionId", "regionName");
            ViewBag.storeId = new SelectList(db.Stores, "storeId", "name");
            return View();
        }

        // POST: /OpenJob/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="openJobsId,jobId,storeId,regionId,isApproved")] OpenJob openjob)
        {
            if (ModelState.IsValid)
            {
                db.OpenJobs.Add(openjob);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.jobId = new SelectList(db.Jobs, "jobId", "position", openjob.jobId);
            ViewBag.regionId = new SelectList(db.Regions, "regionId", "regionName", openjob.regionId);
            ViewBag.storeId = new SelectList(db.Stores, "storeId", "name", openjob.storeId);
            return View(openjob);
        }

        // GET: /OpenJob/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OpenJob openjob = db.OpenJobs.Find(id);
            if (openjob == null)
            {
                return HttpNotFound();
            }
            ViewBag.jobId = new SelectList(db.Jobs, "jobId", "position", openjob.jobId);
            ViewBag.regionId = new SelectList(db.Regions, "regionId", "regionName", openjob.regionId);
            ViewBag.storeId = new SelectList(db.Stores, "storeId", "name", openjob.storeId);
            return View(openjob);
        }

        // POST: /OpenJob/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="openJobsId,jobId,storeId,regionId,isApproved")] OpenJob openjob)
        {
            if (ModelState.IsValid)
            {
                db.Entry(openjob).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.jobId = new SelectList(db.Jobs, "jobId", "position", openjob.jobId);
            ViewBag.regionId = new SelectList(db.Regions, "regionId", "regionName", openjob.regionId);
            ViewBag.storeId = new SelectList(db.Stores, "storeId", "name", openjob.storeId);
            return View(openjob);
        }

        // GET: /OpenJob/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OpenJob openjob = db.OpenJobs.Find(id);
            if (openjob == null)
            {
                return HttpNotFound();
            }
            return View(openjob);
        }

        // POST: /OpenJob/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OpenJob openjob = db.OpenJobs.Find(id);
            db.OpenJobs.Remove(openjob);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
         
         */
    }
}
