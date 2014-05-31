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
    public partial class ApplicantQuestionAnswer : ITrackable
    {
        [DataMember]
        [Display(Name = "Answer ID")]
        public int AnswerId { get; set; }

        [DataMember]
        [Display(Name = "Applicant ID")]
        public Nullable<int> ApplicantId { get; set; }

        [DataMember]
        [Display(Name = "Question ID")]
        public Nullable<int> QuesitonId { get; set; }

        [DataMember]
        [Display(Name = "Answer Json String")]
        public string AnswerJsonString { get; set; }

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

        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}