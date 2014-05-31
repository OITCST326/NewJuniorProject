using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Admin.Service.WorkerRole.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class JobHistory : ITrackable
    {
        [DataMember]
        public int JobHistoryId { get; set; }

        [DataMember]
        public string EmployerName { get; set; }

        [DataMember]
        public string Position { get; set; }

        [DataMember]
        public string Responsibilities { get; set; }

        [DataMember]
        public string Supervisor { get; set; }

        [DataMember]
        public Nullable<decimal> StartingSalary { get; set; }

        [DataMember]
        public Nullable<decimal> EndingSalary { get; set; }

        [DataMember]
        public string ReasonForLeaving { get; set; }

        [DataMember]
        public Nullable<System.DateTime> DateFrom { get; set; }

        [DataMember]
        public Nullable<System.DateTime> DateTo { get; set; }

        [DataMember]
        public string Street { get; set; }

        [DataMember]
        public string Street2 { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public Nullable<StateEnum> State { get; set; }

        [DataMember]
        public string Zip { get; set; }

        [DataMember]
        public string Phone { get; set; }

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