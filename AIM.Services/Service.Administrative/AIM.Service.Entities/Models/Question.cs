using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
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
            this.InterviewQuestions = new List<InterviewQuestion>();
            this.Questionnaires = new List<Questionnaire>();
        }

        [DataMember]
        public int QuestionId { get; set; }
        [DataMember]
        public string QJsonProperties { get; set; }
        [DataMember]
        public Nullable<int> QuestionnaireId { get; set; }
        [DataMember]
        public Nullable<int> InterviewQuestionsId { get; set; }
        [DataMember]
        public List<ApplicantQuestionAnswer> ApplicantQuestionAnswers { get; set; }
        [DataMember]
        public List<InterviewQuestion> InterviewQuestions { get; set; }
        [DataMember]
        public List<Questionnaire> Questionnaires { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}
