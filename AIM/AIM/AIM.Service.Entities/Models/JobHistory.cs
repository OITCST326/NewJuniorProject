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
    public partial class JobHistory : ITrackable
    {
        [DataMember]
        [Display(Name = "Job History ID")]
        public int jobHistoryId { get; set; }

        [DataMember]
        [Display(Name = "Employer Name")]
        public string employerName { get; set; }

        [DataMember]
        [Display(Name = "Position")]
        public string position { get; set; }

        [DataMember]
        [Display(Name = "Responsibilities")]
        public string responsibilities { get; set; }

        [DataMember]
        [Display(Name = "Supervisor")]
        public string supervisor { get; set; }

        [DataMember]
        [Display(Name = "Starting Salary")]
        public decimal? startingSalary { get; set; }

        [DataMember]
        [Display(Name = "Ending Salary")]
        public decimal? endingSalary { get; set; }

        [DataMember]
        [Display(Name = "Reason For Leaving")]
        public string reasonForLeaving { get; set; }

        [DataMember]
        [Display(Name = "Date From")]
        public DateTime? dateFrom { get; set; }

        [DataMember]
        [Display(Name = "Date To")]
        public DateTime? dateTo { get; set; }

        [DataMember]
        [Display(Name = "Street")]
        public string street { get; set; }

        [DataMember]
        [Display(Name = "Street 2")]
        public string street2 { get; set; }

        [DataMember]
        [Display(Name = "City")]
        public string city { get; set; }

        [DataMember]
        [Display(Name = "State")]
        public Nullable<StateEnum> state { get; set; }

        [DataMember]
        [Display(Name = "Zip Code")]
        public string zip { get; set; }

        [DataMember]
        [Display(Name = "Phone Number")]
        public string phone { get; set; }

        [DataMember]
        [Display(Name = "Applicant ID")]
        public Nullable<int> applicantId { get; set; }

        [DataMember]
        [Display(Name = "Applicant")]
        public Applicant Applicant { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}