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
    public partial class Application : ITrackable
    {
        [DataMember]
        [Display(Name = "Application ID")]
        public int ApplicationId { get; set; }

        [DataMember]
        [Display(Name = "Applicant ID")]
        public Nullable<int> ApplicantId { get; set; }

        [DataMember]
        [Display(Name = "Date Created")]
        public Nullable<System.DateTime> DateCreated { get; set; }

        [DataMember]
        [Display(Name = "Pre-Employment Statement")]
        public string PreEmploymentStatement { get; set; }

        [DataMember]
        [Display(Name = "Job ID")]
        public Nullable<int> JobID { get; set; }

        [DataMember]
        [Display(Name = "Status")]
        public Nullable<StatusEnum> Status { get; set; }

        [DataMember]
        [Display(Name = "Salary Expectation")]
        public string SalaryExpectation { get; set; }

        [DataMember]
        [Display(Name = "Full Time")]
        public Nullable<bool> IsFullTime { get; set; }

        [DataMember]
        [Display(Name = "Days")]
        public Nullable<bool> IsDays { get; set; }

        [DataMember]
        [Display(Name = "Evenings")]
        public Nullable<bool> IsEvenings { get; set; }

        [DataMember]
        [Display(Name = "Weekends")]
        public Nullable<bool> IsWeekends { get; set; }

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

        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}