using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Application.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class User : ITrackable
    {
        [DataMember]
        public int userId { get; set; }

        [DataMember]
        public string firstName { get; set; }

        [DataMember]
        public string middleName { get; set; }

        [DataMember]
        public string lastName { get; set; }

        [DataMember]
        public string email { get; set; }

        [DataMember]
        public string socialSecurityNumber { get; set; }

        [DataMember]
        public int? PersonalInfoId { get; set; }

        [DataMember]
        public int? applicantId { get; set; }

        [DataMember]
        public int? applicationId { get; set; }

        [DataMember]
        public int? employeeId { get; set; }

        [DataMember]
        public string userName { get; set; }

        [DataMember]
        public string password { get; set; }

        [DataMember]
        public Applicant Applicant { get; set; }

        [DataMember]
        public Employee Employee { get; set; }

        [DataMember]
        public PersonalInfo PersonalInfo { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}