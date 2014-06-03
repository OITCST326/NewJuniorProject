using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Application : ITrackable
    {
        [DataMember]
        public int ApplicationId { get; set; }
        [DataMember]
        public Nullable<int> ApplicantId { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DateCreated { get; set; }
        [DataMember]
        public string PreEmploymentStatement { get; set; }
        [DataMember]
        public Nullable<int> JobId { get; set; }
        [DataMember]
        public Nullable<int> Status { get; set; }
        [DataMember]
        public string SalaryExpectation { get; set; }
        [DataMember]
        public Nullable<bool> IsFullTime { get; set; }
        [DataMember]
        public Nullable<bool> IsDays { get; set; }
        [DataMember]
        public Nullable<bool> IsEvenings { get; set; }
        [DataMember]
        public Nullable<bool> IsWeekends { get; set; }
        [DataMember]
        public Applicant Applicant { get; set; }
        [DataMember]
        public Job Job { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}
