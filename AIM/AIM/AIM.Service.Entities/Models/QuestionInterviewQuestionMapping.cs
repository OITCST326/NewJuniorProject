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
    public partial class QuestionInterviewQuestionMapping : ITrackable
    {
        [DataMember]
        [Display(Name = "Question ID")]
        public int questionId { get; set; }

        [DataMember]
        [Display(Name = "Interview Questions ID")]
        public int interviewQuestionsId { get; set; }

        [DataMember]
        [Display(Name = "Number Of Questions")]
        public Nullable<int> numberOfQuestions { get; set; }

        [DataMember]
        [Display(Name = "Interview Question")]
        public InterviewQuestion InterviewQuestion { get; set; }

        [DataMember]
        [Display(Name = "Question")]
        public Question Question { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}