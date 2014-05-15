using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using AIM.Service.Entities.Models;
using AIM.Web.Admin.ApplicationServiceReference;

namespace AIM.Web.Admin.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly ApplicationServiceClient _client = new ApplicationServiceClient();

        // GET: /Application/
        public ActionResult Index()
        {
            var applications = _client.GetApplicantsList();
            return View(applications.ToList());
        }

        // GET: /Application/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = _client.GetApplicant(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        // GET: /Application/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Application/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "applicantId,educationId,jobHistoryId,referenceId,userId,applicationId,answerId,hoursId")] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                _client.CreateApplicant(applicant);
                return RedirectToAction("Index");
            }

            return View(applicant);
        }

        // GET: /Application/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = _client.GetApplicant(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        // POST: /Application/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "applicantId,educationId,jobHistoryId,referenceId,userId,applicationId,answerId,hoursId")] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                _client.UpdateApplicant(applicant);
                return RedirectToAction("Index");
            }
            return View(applicant);
        }

        // GET: /Application/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = _client.GetApplicant(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        // POST: /Application/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Applicant applicant = _client.GetApplicant(id);
            _client.DeleteApplicant(id);
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

