namespace AIM.Application.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Question
    {
        public Question()
        {
            ApplicantQuestionAnswers = new HashSet<ApplicantQuestionAnswer>();
            InterviewQuestions = new HashSet<InterviewQuestion>();
            Questionnaires = new HashSet<Questionnaire>();
        }

        public int QuestionId { get; set; }

        public string QJsonProperties { get; set; }

        public int? QuestionnaireId { get; set; }

        public int? InterviewQuestionsId { get; set; }

        public virtual ICollection<ApplicantQuestionAnswer> ApplicantQuestionAnswers { get; set; }

        public virtual ICollection<InterviewQuestion> InterviewQuestions { get; set; }

        public virtual ICollection<Questionnaire> Questionnaires { get; set; }
    }
}
