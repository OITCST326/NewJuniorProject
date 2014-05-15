using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using AIM.Application.Service.Entities.Models;
using AIM.Web.Application.PersonalInfoServiceReference;

namespace AIM.Web.Application.Controllers
{
    public class PersonalInfoController : Controller
    {
        private readonly PersonalInfoServiceClient _client = new PersonalInfoServiceClient();

        // GET: /PersonalInfo/
        public ActionResult Index()
        {
            var personalInfo = _client.GetPersonalInfoList();
            return View(personalInfo.ToList());
        }

        // GET: /PersonalInfo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalInfo personalinfo = _client.GetPersonalInfo(id);
            if (personalinfo == null)
            {
                return HttpNotFound();
            }
            return View(personalinfo);
        }

        // GET: /PersonalInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /PersonalInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonalInfoId,alias,street,street2,city,state,zip,phone,userId")] PersonalInfo personalinfo)
        {
            if (ModelState.IsValid)
            {
                _client.CreatePersonalInfo(personalinfo);
                return RedirectToAction("Index");
            }

            return View(personalinfo);
        }

        // GET: /PersonalInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalInfo personalinfo = _client.GetPersonalInfo(id);
            if (personalinfo == null)
            {
                return HttpNotFound();
            }
            return View(personalinfo);
        }

        // POST: /PersonalInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonalInfoId,alias,street,street2,city,state,zip,phone,userId")] PersonalInfo personalinfo)
        {
            if (ModelState.IsValid)
            {
                _client.DeletePersonalInfo(personalinfo.PersonalInfoId);
                _client.CreatePersonalInfo(personalinfo);
                return RedirectToAction("Index");
            }
            return View(personalinfo);
        }

        // GET: /PersonalInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalInfo personalinfo = _client.GetPersonalInfo(id);
            if (personalinfo == null)
            {
                return HttpNotFound();
            }
            return View(personalinfo);
        }

        // POST: /PersonalInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonalInfo personalinfo = _client.GetPersonalInfo(id);
            _client.DeletePersonalInfo(personalinfo.PersonalInfoId);
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