using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;
using AIM.Web.Admin.Models.EntityModels;
using TrackableEntities.Client;
using TrackableEntities.Common;

namespace AIM.Web.Admin.Controllers
{
    public class UserController : Controller
    {
        // Address for Web API service
        const string ServiceBaseAddress = "http://aimadminstrativeservice.cloudapp.net/" + "/";

        // Address for Web API service if running service locally
        //const string ServiceBaseAddress = "http://localhost:" + "58528" + "/";



        // GET: /User/
        public ActionResult Index()
        {
            var customers = GetUsers();
            
            return View(customers);
        }

        // GET: /User/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            User user = GetUser(id);

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
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="UserId,FirstName,MiddleName,LastName,Email,SocialSecurityNumber,SocialSecurityNumberCoder,PersonalInfoId,ApplicantId,ApplicationId,EmployeeId")] User newUser)
        {
            if (ModelState.IsValid)
            {
                CreateUser(newUser);
                return RedirectToAction("Index");
            }
            return View(newUser);
        }

        // GET: /User/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            User user = GetUser(id);

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
        public ActionResult Edit([Bind(Include = "UserId,FirstName,MiddleName,LastName,Email,SocialSecurityNumber,SocialSecurityNumberCoder,PersonalInfoId,ApplicantId,ApplicationId,EmployeeId")] User modifiedUser)
        {
            if (ModelState.IsValid)
            {
                // Start change-tracking the model
                User initialUser = GetUser(modifiedUser.UserId);
                var changeTracker = new ChangeTrackingCollection<User>(initialUser);

                // Modify user details
                initialUser = modifiedUser;

                // Submit changes
                var changedUser = changeTracker.GetChanges().SingleOrDefault();
                var updatedUser = UpdateUser(changedUser);

                // Merge changes
                changeTracker.MergeChanges(updatedUser);

                return RedirectToAction("Index");
            }
            return View(modifiedUser);
        }

        // GET: /User/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            User user = GetUser(id);

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
            // Delete the user
            DeleteUser(id);

            // Verify order was deleted
            var deleted = VerifyUserDeleted(id);
            ViewBag.DeletedMessage(deleted ?
                "User was successfully deleted" :
                "User was not deleted");

            return RedirectToAction("Index");
        }

        /************************************************************************************/
        /*                              Web API calls for User                              */
        /************************************************************************************/


        /// <summary>
        /// Calls the Administrative Web Service to request a list of all users from the
        /// AIM Database
        /// </summary>
        /// <returns>A list of all Users</returns>
        private static IEnumerable<User> GetUsers()
        {
            try
            {
                var client = new HttpClient { BaseAddress = new Uri(ServiceBaseAddress) };
                const string request = "api/User";
                var response = client.GetAsync(request).Result;
                response.EnsureSuccessStatusCode();
                var result = response.Content.ReadAsAsync<IEnumerable<User>>().Result;
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Calls the Administrative Web Service to request an induviual users by UserID
        /// from the AIM Database 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>A User with the userId</returns>
        private static User GetUser(int? userId)
        {
            User result;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ServiceBaseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var request = "api/User/" + userId;
                var response = client.GetAsync(request).Result;
                response.EnsureSuccessStatusCode();
                result = response.Content.ReadAsAsync<User>().Result;
            }
            return result;
        }

        /// <summary>
        /// Calls the Administrative Web Service to request to create new User in the 
        /// AIM Database
        /// </summary>
        /// <param name="user"></param>
        /// <returns>User</returns>
        private static User CreateUser(User user)
        {
            User result;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ServiceBaseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                const string request = "api/User";
                var response = client.PostAsJsonAsync(request, user).Result;
                response.EnsureSuccessStatusCode();
                result = response.Content.ReadAsAsync<User>().Result;
            }
            return result;
        }

        /// <summary>
        /// Calls the Administrative Web Service to request User to be updated in 
        /// the AIM Database
        /// </summary>
        /// <param name="client"></param>
        /// <param name="user"></param>
        /// <returns>User</returns>
        private static User UpdateUser(User user)
        {
            User result;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ServiceBaseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                const string request = "api/User";
                var response = client.PutAsJsonAsync(request, user).Result;
                response.EnsureSuccessStatusCode();
                result = response.Content.ReadAsAsync<User>().Result;
            }
            return result;
        }

        /// <summary>
        /// Calls the Administrative Web Service to request User to be deleted from 
        /// the AIM Database
        /// </summary>
        /// <param name="userId"></param>
        private static void DeleteUser(int? userId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ServiceBaseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var request = "api/User/" + userId;
                var response = client.DeleteAsync(request);
                response.Result.EnsureSuccessStatusCode();
            }
        }

        /// <summary>
        /// Calls the Administrative Web Service to verify that the User has been 
        /// deleted from the AIM Database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>bool</returns>
        private static bool VerifyUserDeleted(int userId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ServiceBaseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string request = "api/User/" + userId;
                var response = client.GetAsync(request).Result;
                if (response.IsSuccessStatusCode) return false;
            }
            return true;
        }
    }
}
