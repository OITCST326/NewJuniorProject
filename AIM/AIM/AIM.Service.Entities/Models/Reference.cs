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
    public partial class Reference : ITrackable
    {
        [DataMember]
        [Display(Name = "Reference ID")]
        public int referenceId { get; set; }

        [DataMember]
        [Display(Name = "Reference Full Name")]
        public string refFullName { get; set; }

        [DataMember]
        [Display(Name = "Reference Company")]
        public string refCompany { get; set; }

        [DataMember]
        [Display(Name = "Reference Title")]
        public string refTitle { get; set; }

        [DataMember]
        [Display(Name = "Reference Phone Number")]
        public string refPhone { get; set; }

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