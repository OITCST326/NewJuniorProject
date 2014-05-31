using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Application.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class InterviewQuestion : ITrackable
    {
        public InterviewQuestion()
        {
            this.Jobs = new List<Job>();
            this.QuestionInterviewQuestionMappings = new List<QuestionInterviewQuestionMapping>();
        }

        [DataMember]
        public int interviewQuestionsId { get; set; }

        [DataMember]
        public int? questionId { get; set; }

        [DataMember]
        public int? jobId { get; set; }

        [DataMember]
        public List<Job> Jobs { get; set; }

        [DataMember]
        public List<QuestionInterviewQuestionMapping> QuestionInterviewQuestionMappings { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}