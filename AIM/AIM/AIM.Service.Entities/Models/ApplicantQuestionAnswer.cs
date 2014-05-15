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
    public partial class ApplicantQuestionAnswer : ITrackable
    {
        [DataMember]
        [Display(Name = "Answer ID")]
        public int answerId { get; set; }

        [DataMember]
        [Display(Name = "Applicant ID")]
        public Nullable<int> applicantId { get; set; }

        [DataMember]
        [Display(Name = "Question ID")]
        public Nullable<int> quesitonId { get; set; }

        [DataMember]
        [Display(Name = "Answer Json String")]
        public string answerJsonString { get; set; }

        [DataMember]
        [Display(Name = "Applicant")]
        public Applicant Applicant { get; set; }

        [DataMember]
        [Display(Name = "Question")]
        public Question Question { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}