using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Admin.Service.WorkerRole.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Hour : ITrackable
    {
        public Hour()
        {
            this.Jobs = new List<Job>();
        }

        [DataMember]
        public int HoursId { get; set; }

        [DataMember]
        public Nullable<int> ApplicantId { get; set; }

        [DataMember]
        public Nullable<System.TimeSpan> MonOpen { get; set; }

        [DataMember]
        public Nullable<System.TimeSpan> MonClose { get; set; }

        [DataMember]
        public Nullable<System.TimeSpan> TueOpen { get; set; }

        [DataMember]
        public Nullable<System.TimeSpan> TueClose { get; set; }

        [DataMember]
        public Nullable<System.TimeSpan> WedOpen { get; set; }

        [DataMember]
        public Nullable<System.TimeSpan> WedClose { get; set; }

        [DataMember]
        public Nullable<System.TimeSpan> ThursOpen { get; set; }

        [DataMember]
        public Nullable<System.TimeSpan> ThursClose { get; set; }

        [DataMember]
        public Nullable<System.TimeSpan> FriOpen { get; set; }

        [DataMember]
        public Nullable<System.TimeSpan> FriClose { get; set; }

        [DataMember]
        public Nullable<System.TimeSpan> SatOpen { get; set; }

        [DataMember]
        public Nullable<System.TimeSpan> SatClose { get; set; }

        [DataMember]
        public Nullable<System.TimeSpan> SunOpen { get; set; }

        [DataMember]
        public Nullable<System.TimeSpan> SunClose { get; set; }

        [DataMember]
        public Applicant Applicant { get; set; }

        [DataMember]
        public List<Job> Jobs { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}