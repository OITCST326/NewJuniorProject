using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AIM.Web.Application.Client;
using AIM.Web.ClientApp.Models.EntityModels;

namespace AIM.Web.ClientApp.Controllers
{
    public class QuestionnaireController : Controller
    {
        // GET: Questionnaire
        public async Task<ViewResult> Index(int jobId = 1)
        {

            Questionnaire questionnaire = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://aimadminstrativeservice.cloudapp.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                string request = "api/Questionnaire?jobId=" + jobId;
                HttpResponseMessage response = await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    questionnaire = await response.Content.ReadAsAsync<Questionnaire>();
                }
            }

            return View(questionnaire);
        }

    }
}