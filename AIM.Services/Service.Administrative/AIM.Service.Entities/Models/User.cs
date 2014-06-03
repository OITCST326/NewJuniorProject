using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class User : ITrackable
    {
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string SocialSecurityNumber { get; set; }
        [DataMember]
        public Nullable<int> PersonalInfoId { get; set; }
        [DataMember]
        public Nullable<int> ApplicantId { get; set; }
        [DataMember]
        public Nullable<int> ApplicationId { get; set; }
        [DataMember]
        public Nullable<int> EmployeeId { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string AspNetUsersId { get; set; }
        [DataMember]
        public Applicant Applicant { get; set; }
        [DataMember]
        public AspNetUser AspNetUser { get; set; }
        [DataMember]
        public Employee Employee { get; set; }
        [DataMember]
        public PersonalInfo PersonalInfo { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}
