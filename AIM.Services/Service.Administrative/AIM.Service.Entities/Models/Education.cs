using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Education : ITrackable
    {
        [DataMember]
        public int EducationId { get; set; }
        [DataMember]
        public string SchoolName { get; set; }
        [DataMember]
        public string Degree { get; set; }
        [DataMember]
        public Nullable<System.DateTime> Graduated { get; set; }
        [DataMember]
        public string YearsAttended { get; set; }
        [DataMember]
        public string Street { get; set; }
        [DataMember]
        public string Street2 { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public Nullable<int> State { get; set; }
        [DataMember]
        public string Zip { get; set; }
        [DataMember]
        public Nullable<int> ApplicantId { get; set; }
        [DataMember]
        public Applicant Applicant { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}
