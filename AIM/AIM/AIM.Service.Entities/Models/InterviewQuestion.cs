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
    public partial class InterviewQuestion : ITrackable
    {
        public InterviewQuestion()
        {
            this.Jobs = new List<Job>();
            this.QuestionInterviewQuestionMappings = new List<QuestionInterviewQuestionMapping>();
        }

        [DataMember]
        [Display(Name = "Interview Questions ID")]
        public int interviewQuestionsId { get; set; }

        [DataMember]
        [Display(Name = "Question ID")]
        public Nullable<int> questionId { get; set; }

        [DataMember]
        [Display(Name = "Job ID")]
        public Nullable<int> jobId { get; set; }

        [DataMember]
        [Display(Name = "Jobs List")]
        public List<Job> Jobs { get; set; }

        [DataMember]
        [Display(Name = "Question Interview Question Mappings")]
        public List<QuestionInterviewQuestionMapping> QuestionInterviewQuestionMappings { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}