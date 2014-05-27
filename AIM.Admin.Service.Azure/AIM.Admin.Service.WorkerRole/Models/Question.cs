using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Admin.Service.WorkerRole.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Question : ITrackable
    {
        public Question()
        {
            this.ApplicantQuestionAnswers = new List<ApplicantQuestionAnswer>();
            this.InterviewQuestions = new List<InterviewQuestion>();
            this.Questionnaires = new List<Questionnaire>();
        }

        [DataMember]
        [Display(Name = "Question ID")]
        public int QuestionId { get; set; }

        [DataMember]
        [Display(Name = "Q Json Properties")]
        public string QJsonProperties { get; set; }

        [DataMember]
        [Display(Name = "Questionnaire ID")]
        public Nullable<int> QuestionnaireId { get; set; }

        [DataMember]
        [Display(Name = "Interview Questions ID")]
        public Nullable<int> InterviewQuestionsId { get; set; }

        [DataMember]
        [Display(Name = "Applicant Question Answers")]
        public List<ApplicantQuestionAnswer> ApplicantQuestionAnswers { get; set; }

        [DataMember]
        [Display(Name = "Question Questionnaires")]
        public List<InterviewQuestion> InterviewQuestions { get; set; }

        [DataMember]
        [Display(Name = "Question Questionnaires")]
        public List<Questionnaire> Questionnaires { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }

        [JsonProperty, DataMember]
        [Display(Name = "Question Id")]
        public int? QJsonId { get; set; }

        [JsonProperty, DataMember]
        [Display(Name = "Question Type")]
        public TypeEnum? QJsonType { get; set; }

        [JsonProperty, DataMember]
        [Display(Name = "Question")]
        public string QJsonText { get; set; }

        [JsonProperty, DataMember]
        [Display(Name = "Question Option")]
        public IList<string> QJsonOptionList { get; set; }

        [JsonProperty, DataMember]
        [Display(Name = "Desired Answer")]
        public IList<string> QJsonAnswerList { get; set; }
    }
}