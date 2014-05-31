using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using AIM.Application.Service.Entities.Models;
using AIM.Web.Application.JobServiceReference;

namespace AIM.Web.Application.Controllers
{
    public class JobController : Controller
    {
        private readonly JobServiceClient _client = new JobServiceClient();

        // GET: /Job/
        public ActionResult Index()
        {
            var jobs = _client.GetJobsList();
            return View(jobs.ToList());
        }

        // GET: /Job/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = _client.GetJob(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // GET: /Job/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Job/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "jobId,position,description,fullPartTime,salaryRange,questionnaireId,hoursId,InterviewquestionId")] Job job)
        {
            if (ModelState.IsValid)
            {
                _client.CreateJob(job);
                return RedirectToAction("Index");
            }

            return View(job);
        }

        // GET: /Job/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = _client.GetJob(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // POST: /Job/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "jobId,position,description,fullPartTime,salaryRange,questionnaireId,hoursId,InterviewquestionId")] Job job)
        {
            if (ModelState.IsValid)
            {
                _client.DeleteJob(job.jobId);
                _client.CreateJob(job);
                return RedirectToAction("Index");
            }

            return View(job);
        }

        // GET: /Job/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job job = _client.GetJob(id);
            if (job == null)
            {
                return HttpNotFound();
            }
            return View(job);
        }

        // POST: /Job/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Job job = _client.GetJob(id);
            _client.DeleteJob(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            var dispose = _client as IDisposable;
            if (dispose != null)
            {
                dispose.Dispose();
            }
        }
    }
}
