using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Application.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class QuestionInterviewQuestionMapping : ITrackable
    {
        [DataMember]
        public int questionId { get; set; }

        [DataMember]
        public int interviewQuestionsId { get; set; }

        [DataMember]
        public int? numberOfQuestions { get; set; }

        [DataMember]
        public InterviewQuestion InterviewQuestion { get; set; }

        [DataMember]
        public Question Question { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}