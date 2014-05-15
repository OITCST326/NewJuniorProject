using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Application : ITrackable
    {
        [DataMember]
        [Display(Name = "Application ID")]
        public int applicationId { get; set; }

        [DataMember]
        [Display(Name = "Applicant ID")]
        public Nullable<int> applicantId { get; set; }

        [DataMember]
        [Display(Name = "Date Created")]
        public DateTime? dateCreated { get; set; }

        [DataMember]
        [Display(Name = "Pre-Employment Statement")]
        public string preEmploymentStatement { get; set; }

        [DataMember]
        [Display(Name = "Job ID")]
        public Nullable<int> jobId { get; set; }

        [DataMember]
        [Display(Name = "Status")]
        public Nullable<StatusEnum> status { get; set; }

        [DataMember]
        [Display(Name = "Salary Expectation")]
        public string salaryExpectation { get; set; }

        [DataMember]
        [Display(Name = "Full Time")]
        public bool isFullTime { get; set; }

        [DataMember]
        [Display(Name = "Days")]
        public bool isDays { get; set; }

        [DataMember]
        [Display(Name = "Evenings")]
        public bool isEvenings { get; set; }

        [DataMember]
        [Display(Name = "Weekends")]
        public bool isWeekends { get; set; }

        [DataMember]
        [Display(Name = "Applicant")]
        public Applicant Applicant { get; set; }

        [DataMember]
        [Display(Name = "Job")]
        public Job Job { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}