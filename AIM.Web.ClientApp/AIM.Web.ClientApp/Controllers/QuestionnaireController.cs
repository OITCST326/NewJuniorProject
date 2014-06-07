using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AIM.Web.Application.Client;

namespace AIM.Web.ClientApp.Controllers
{
    public class QuestionnaireController : Controller
    {
        private readonly QuestionnaireServiceClient _client = new QuestionnaireServiceClient();

        // GET: Questionnaire
        public async Task<ViewResult> Index()
        {


            return View();
        }
    }
}