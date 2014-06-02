using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AIM.Admin.Web.AdministrativeServiceReference;

namespace AIM.Admin.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly AdministrativeServiceClient _client = new AdministrativeServiceClient();

        public UserController()
        {
            _client = new AdministrativeServiceClient();
        }

        // GET: /User/
        public ActionResult Index()
        {
            var users = _client.GetUsersList();
            return View(users.ToList());
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
        public ActionResult Create([Bind(Include = "UserId,FirstName,MiddleName,LastName,Email,SocialSecurityNumber," +
                                                   "PersonalInfoId,ApplicantId,ApplicationId,EmployeeId,UserName," +
                                                   "Password,AspNetUserId")] User user)
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,FirstName,MiddleName,LastName,Email,SocialSecurityNumber," +
                                                 "PersonalInfoId,ApplicantId,ApplicationId,EmployeeId,UserName," +
                                                 "Password,AspNetUserId")] User user)
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
