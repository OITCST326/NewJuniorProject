using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using AIM.Web.Admin.Models.EntityModels;
using TrackableEntities.Common;

namespace AIM.Web.Admin.Controllers
{
    public class UserController : Controller
    {
        //private readonly UserServiceClient _client = new UserServiceClient();
        const string ServiceBaseAddress = "http://aimadminstrativeservice.cloudapp.net/" + "/";
        readonly HttpClient _client = new HttpClient { BaseAddress = new Uri(ServiceBaseAddress) };

        public UserController()
        {
            //_client = new UserServiceClient(); 
        }

        // GET: /User/
        public ActionResult Index()
        {
            //var users = _client.GetUsersList();
            //return View(users.ToList());
            const string request = "api/User";
            var response = _client.GetAsync(request).Result;
            response.EnsureSuccessStatusCode();
            var result = response.Content.ReadAsAsync<IEnumerable<User>>().Result;
            return View(result);
        }

        // GET: /User/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            string request = "api/User/" + id;
            var response = _client.GetAsync(request).Result;
            response.EnsureSuccessStatusCode();
            var result = response.Content.ReadAsAsync<User>().Result;

            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        // GET: /User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="UserId,FirstName,MiddleName,LastName,Email,SocialSecurityNumber,SocialSecurityNumberCoder,PersonalInfoId,ApplicantId,ApplicationId,EmployeeId")] User user)
        {
            if (ModelState.IsValid)
            {
                const string request = "api/User";
                var response = _client.PostAsJsonAsync(request, user).Result;
                response.EnsureSuccessStatusCode();
                var result = response.Content.ReadAsAsync<User>().Result;
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

            string request = "api/User/" + id;
            var response = _client.GetAsync(request).Result;
            response.EnsureSuccessStatusCode();
            var result = response.Content.ReadAsAsync<User>().Result;

            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        // POST: /User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,FirstName,MiddleName,LastName,Email,SocialSecurityNumber,SocialSecurityNumberCoder,PersonalInfoId,ApplicantId,ApplicationId,EmployeeId")] User user)
        {
            if (ModelState.IsValid)
            {
                const string request = "api/User";
                var response = _client.PutAsJsonAsync(request, user).Result;
                response.EnsureSuccessStatusCode();
                var result = response.Content.ReadAsAsync<User>().Result;
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

            string request = "api/User/" + id;
            var response = _client.GetAsync(request).Result;
            response.EnsureSuccessStatusCode();
            var result = response.Content.ReadAsAsync<User>().Result;

            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        // POST: /User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            string request = "api/Order/" + id;
            var response = _client.DeleteAsync(request);
            response.Result.EnsureSuccessStatusCode();
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
