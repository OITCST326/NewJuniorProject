//using System.IO;
//using System.Text;
//using AIM.Service.Entities.Models;
//using AIM.Web.Admin.Models;
//using AIM.Web.Admin.QuestionServiceReference;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Web.Mvc;

//namespace AIM.Web.Admin.Controllers
//{
//    public class QuestionController : Controller
//    {
//        private readonly QuestionServiceClient _client = new QuestionServiceClient();
//        private static readonly StringBuilder Sb = new StringBuilder();
//        private readonly StringWriter _sw = new StringWriter(Sb);

//        // GET: /Question/
//        public ActionResult Index()
//        {
//            var questions = _client.GetQuestionsList();

//            // expand JSON Proterties
//            foreach (Question question in questions)
//            {
//                question.qJsonOptionList = new List<string>();
//                question.qJsonAnswerList = new List<string>();

//                var expandedQJsonProperties = JsonConvert.DeserializeObject<Question>(question.qJsonProperties);

//                question.qJsonId = expandedQJsonProperties.qJsonId;
//                question.qJsonType = expandedQJsonProperties.qJsonType;
//                question.qJsonText = expandedQJsonProperties.qJsonText;

//                for (var i = 0; i < expandedQJsonProperties.qJsonOptionList.Count(); ++i)
//                {
//                    question.qJsonOptionList.Add(expandedQJsonProperties.qJsonOptionList[i]);
//                }

//                for (var i = 0; i < expandedQJsonProperties.qJsonAnswerList.Count(); ++i)
//                {
//                    question.qJsonAnswerList.Add(expandedQJsonProperties.qJsonAnswerList[i]);
//                }
//            }
//            return View(questions.ToList());
//        }

//        // GET: /Question/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Question question = _client.GetQuestion(id);
//            if (question == null)
//            {
//                return HttpNotFound();
//            }

//            // expand JSON Proterties
//            question.qJsonOptionList = new List<string>();
//            question.qJsonAnswerList = new List<string>();

//            var expandedQJsonProperties = JsonConvert.DeserializeObject<Question>(question.qJsonProperties);

//            question.qJsonId = expandedQJsonProperties.qJsonId;
//            question.qJsonType = expandedQJsonProperties.qJsonType;
//            question.qJsonText = expandedQJsonProperties.qJsonText;

//            for (var i = 0; i < expandedQJsonProperties.qJsonOptionList.Count(); ++i)
//            {
//                question.qJsonOptionList.Add(expandedQJsonProperties.qJsonOptionList[i]);
//            }

//            for (var i = 0; i < expandedQJsonProperties.qJsonAnswerList.Count(); ++i)
//            {
//                question.qJsonAnswerList.Add(expandedQJsonProperties.qJsonAnswerList[i]);
//            }

//            return View(question);
//        }

//        // GET: /Question/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: /Question/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "questionId,qJsonProperties,qJsonId,qJsonType,qJsonText,qJsonOptionList," +
//                                                   "qJsonAnswerList,questionnaireId,interviewQuestionsId")] Question question)
//        {
//            // Create JSON string for JSON Properties
//            var jsonQuestion = new JsonQuestion
//            {
//                qJsonId = question.qJsonId,
//                qJsonType = question.qJsonType,
//                qJsonText = question.qJsonText,
//                qJsonOptionList = new List<string>(question.qJsonOptionList),
//                qJsonAnswerList = new List<string>(question.qJsonAnswerList)
//            };

//            string json = JsonConvert.SerializeObject(jsonQuestion, Formatting.Indented);

//            question.qJsonProperties = json;

//            if (ModelState.IsValid)
//            {
//                _client.CreateQuestion(question);
//                return RedirectToAction("Index");
//            }

//            return View(question);
//        }

//        // GET: /Question/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Question question = _client.GetQuestion(id);
//            if (question == null)
//            {
//                return HttpNotFound();
//            }

//            // expand JSON Proterties
//            question.qJsonOptionList = new List<string>();
//            question.qJsonAnswerList = new List<string>();

//            var expandedQJsonProperties = JsonConvert.DeserializeObject<Question>(question.qJsonProperties);

//            question.qJsonId = expandedQJsonProperties.qJsonId;
//            question.qJsonType = expandedQJsonProperties.qJsonType;
//            question.qJsonText = expandedQJsonProperties.qJsonText;

//            for (var i = 0; i < expandedQJsonProperties.qJsonOptionList.Count(); ++i)
//            {
//                question.qJsonOptionList.Add(expandedQJsonProperties.qJsonOptionList[i]);
//            }

//            for (var i = 0; i < expandedQJsonProperties.qJsonAnswerList.Count(); ++i)
//            {
//                question.qJsonAnswerList.Add(expandedQJsonProperties.qJsonAnswerList[i]);
//            }

//            return View(question);
//        }

//        // POST: /Question/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "questionId,qJsonProperties,qJsonId,qJsonType,qJsonText,qJsonOptionList," +
//                                                 "qJsonAnswerList,questionnaireId,interviewQuestionsId")] Question question)
//        {
//            // Create JSON string for JSON Properties
//            var jsonQuestion = new JsonQuestion
//            {
//                qJsonId = question.qJsonId,
//                qJsonType = question.qJsonType,
//                qJsonText = question.qJsonText,
//                qJsonOptionList = new List<string>(question.qJsonOptionList),
//                qJsonAnswerList = new List<string>(question.qJsonAnswerList)
//            };

//            string json = JsonConvert.SerializeObject(jsonQuestion, Formatting.Indented);

//            question.qJsonProperties = json;

//            if (ModelState.IsValid)
//            {
//                _client.UpdateQuestion(question);
//                return RedirectToAction("Index");
//            }

//            return View(question);
//        }

//        // GET: /Question/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }

//            Question question = _client.GetQuestion(id);

//            if (question == null)
//            {
//                return HttpNotFound();
//            }

//            // expand JSON Proterties
//            question.qJsonOptionList = new List<string>();
//            question.qJsonAnswerList = new List<string>();

//            var expandedQJsonProperties = JsonConvert.DeserializeObject<Question>(question.qJsonProperties);

//            question.qJsonId = expandedQJsonProperties.qJsonId;
//            question.qJsonType = expandedQJsonProperties.qJsonType;
//            question.qJsonText = expandedQJsonProperties.qJsonText;

//            for (var i = 0; i < expandedQJsonProperties.qJsonOptionList.Count(); ++i)
//            {
//                question.qJsonOptionList.Add(expandedQJsonProperties.qJsonOptionList[i]);
//            }

//            for (var i = 0; i < expandedQJsonProperties.qJsonAnswerList.Count(); ++i)
//            {
//                question.qJsonAnswerList.Add(expandedQJsonProperties.qJsonAnswerList[i]);
//            }

//            return View(question);
//        }

//        // POST: /Question/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            Question question = _client.GetQuestion(id);
//            _client.DeleteQuestion(id);
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            var dispose = _client as IDisposable;
//            if (dispose != null)
//            {
//                dispose.Dispose();
//            }
//        }
//    }
//}