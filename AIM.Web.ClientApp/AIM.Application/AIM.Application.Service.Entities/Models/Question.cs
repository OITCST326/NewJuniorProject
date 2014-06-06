using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Application.Service.Entities.Models
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
        [DisplayName("Question ID")]
        public int questionId { get; set; }

        [DataMember]
        [DisplayName("Question JSON String")]
        public string qJsonProperties { get; set; }

        [DataMember]
        [DisplayName("Questionnaire ID")]
        public Nullable<int> questionnaireId { get; set; }

        [DataMember]
        [DisplayName("Interview Question ID")]
        public int interviewQuestionsId { get; set; }

        [DataMember]
        public List<ApplicantQuestionAnswer> ApplicantQuestionAnswers { get; set; }

        [DataMember]
        public List<QuestionInterviewQuestionMapping> QuestionInterviewQuestionMappings { get; set; }

        [DataMember]
        public List<QuestionQuestionnaire> QuestionQuestionnaires { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [DataMember]
        [DisplayName("Quesiton ID")]
        public int qJsonId { get; set; }

        [DataMember]
        [DisplayName("Question Type")]
        public TypeEnum qJsonType { get; set; }

        [DataMember]
        [DisplayName("Question")]
        public string qJsonText { get; set; }

        [DataMember]
        [DisplayName("Selectable Options")]
        public IList<string> qJsonOptionList { get; set; }

        [DataMember]
        [DisplayName("Correct Answer")]
        public IList<string> qJsonAnswerList { get; set; }
    }
}