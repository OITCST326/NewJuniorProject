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
    public partial class User : ITrackable
    {
        [DataMember]
        [Display(Name = "User ID")]
        public int userId { get; set; }

        [DataMember]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [DataMember]
        [Display(Name = "Middle Name")]
        public string middleName { get; set; }

        [DataMember]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [DataMember]
        [Display(Name = "Email Address")]
        public string email { get; set; }

        [DataMember]
        [Display(Name = "SSN")]
        public string socialSecurityNumber { get; set; }

        [DataMember]
        [Display(Name = "Personal Info ID")]
        public Nullable<int> PersonalInfoId { get; set; }

        [DataMember]
        [Display(Name = "Applicant ID")]
        public Nullable<int> applicantId { get; set; }

        [DataMember]
        [Display(Name = "Application ID")]
        public Nullable<int> applicationId { get; set; }

        [DataMember]
        [Display(Name = "Employee ID")]
        public Nullable<int> employeeId { get; set; }

        [DataMember]
        [Display(Name = "Username")]
        public string userName { get; set; }

        [DataMember]
        [Display(Name = "Password")]
        public string password { get; set; }

        [DataMember]
        [Display(Name = "Applicant")]
        public Applicant Applicant { get; set; }

        [DataMember]
        [Display(Name = "Employee")]
        public Employee Employee { get; set; }

        [DataMember]
        [Display(Name = "Personal Info")]
        public PersonalInfo PersonalInfo { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}