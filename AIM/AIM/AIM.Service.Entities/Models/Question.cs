using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Question : ITrackable
    {
        public Question()
        {
            this.ApplicantQuestionAnswers = new List<ApplicantQuestionAnswer>();
            this.QuestionInterviewQuestionMappings = new List<QuestionInterviewQuestionMapping>();
            this.QuestionQuestionnaires = new List<QuestionQuestionnaire>();
        }

        [DataMember]
        [Display(Name = "Question ID")]
        public int questionId { get; set; }

        [DataMember]
        [Display(Name = "Q Json Properties")]
        public string qJsonProperties { get; set; }

        [DataMember]
        [Display(Name = "Questionnaire ID")]
        public Nullable<int> questionnaireId { get; set; }

        [DataMember]
        [Display(Name = "Interview Questions ID")]
        public Nullable<int> interviewQuestionsId { get; set; }

        [DataMember]
        [Display(Name = "Applicant Question Answers")]
        public List<ApplicantQuestionAnswer> ApplicantQuestionAnswers { get; set; }

        [DataMember]
        [Display(Name = "Question Interview Question Mappings")]
        public List<QuestionInterviewQuestionMapping> QuestionInterviewQuestionMappings { get; set; }

        [DataMember]
        [Display(Name = "Question Questionnaires")]
        public List<QuestionQuestionnaire> QuestionQuestionnaires { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [DataMember]
        [Display(Name = "Question Id")]
        public Nullable<int> qJsonId { get; set; }

        [DataMember]
        [Display(Name = "Question Type")]
        public Nullable<TypeEnum> qJsonType { get; set; }

        [DataMember]
        [Display(Name = "Question")]
        public string qJsonText { get; set; }

        [DataMember]
        [Display(Name = "Question Option")]
        public IList<string> qJsonOptionList { get; set; }

        [DataMember]
        [Display(Name = "Desired Answer")]
        public IList<string> qJsonAnswerList { get; set; }
    }
}