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
    public partial class Education : ITrackable
    {
        [DataMember]
        [Display(Name = "Education ID")]
        public int educationId { get; set; }

        [DataMember]
        [Display(Name = "School Name")]
        public string schoolName { get; set; }

        [DataMember]
        [Display(Name = "Degree")]
        public string degree { get; set; }

        [DataMember]
        [Display(Name = "Date Graduated")]
        public DateTime? graduated { get; set; }

        [DataMember]
        [Display(Name = "Years Attended")]
        public string yearsAttended { get; set; }

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
        [Display(Name = "Applicant ID")]
        public Nullable<int> applicantId { get; set; }

        [DataMember]
        [Display(Name = "Applicant")]
        public Applicant Applicant { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}