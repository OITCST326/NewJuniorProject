using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using AIM.Service.Entities.Models;
using AIM.Web.Admin.QuestionServiceReference;
using Newtonsoft.Json;

namespace AIM.Web.Admin.Controllers
{
    public class QuestionController : Controller
    {
        private readonly QuestionServiceClient _client = new QuestionServiceClient();

        // GET: /Question/
        public ActionResult Index()
        {
            var questions = _client.GetQuestionsList();

            //foreach (Question question in questions)
            //{
            //}
            return View(questions.ToList());
        }

        // GET: /Question/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Question question = _client.GetQuestion(id);
            if (question == null)
            {
                return HttpNotFound();
            }
            return View(question);
        }

        // GET: /Question/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Question/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="questionId,qJsonProperties,questionnaireId,interviewQuestionsId")] Question question)
        {
            if (ModelState.IsValid)
            {
                _client.CreateQuestion(question);
                return RedirectToAction("Index");
            }

            return View(question);
        }

        // GET: /Question/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Question question = _client.GetQuestion(id);
            if (question == null)
            {
                return HttpNotFound();
            }
            return View(question);
        }

        // POST: /Question/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="questionId,qJsonProperties,questionnaireId,interviewQuestionsId")] Question question)
        {
            if (ModelState.IsValid)
            {
                _client.DeleteQuestion(question.questionId);
                _client.CreateQuestion(question);
                return RedirectToAction("Index");
            }
            return View(question);
        }

        // GET: /Question/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Question question = _client.GetQuestion(id);
            if (question == null)
            {
                return HttpNotFound();
            }
            return View(question);
        }

        // POST: /Question/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Question question = _client.GetQuestion(id);
            _client.DeleteQuestion(id);
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
