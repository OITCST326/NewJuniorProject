using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AIM.Application.Web.ApplicationServiceReference;

namespace AIM.Application.Web.Controllers
{
    public class UserController : Controller
    {

        private readonly ApplicationServiceClient _client = new ApplicationServiceClient();

        public UserController()
        {
            _client = new ApplicationServiceClient();
        }

        // GET: /User/
        public ActionResult Index()
        {
            var users = _client.GetUsersListAsync().Result;
            return View(users);
        }

        // GET: /User/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = _client.GetUser(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: /User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "userId,firstName,middleName,lastName,email,socialSecurityNumber,socialSecurityNumberCoder,PersonalInfoId,applicantId,applicationId,employeeId")] User user)
        {
            if (ModelState.IsValid)
            {
                _client.CreateUser(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: /User/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = _client.GetUser(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: /User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "userId,firstName,middleName,lastName,email,socialSecurityNumber,socialSecurityNumberCoder,PersonalInfoId,applicantId,applicationId,employeeId")] User user)
        {
            if (ModelState.IsValid)
            {
                _client.DeleteUser(user.UserId);
                _client.CreateUser(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: /User/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = _client.GetUser(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: /User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = _client.GetUser(id);
            _client.DeleteUser(id);
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
