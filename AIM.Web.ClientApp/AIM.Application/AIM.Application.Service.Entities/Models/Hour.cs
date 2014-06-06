using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Application.Service.Entities.Models
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
        public int hoursId { get; set; }

        [DataMember]
        public int? applicantId { get; set; }

        [DataMember]
        public TimeSpan? monOpen { get; set; }

        [DataMember]
        public TimeSpan? monClose { get; set; }

        [DataMember]
        public TimeSpan? tueOpen { get; set; }

        [DataMember]
        public TimeSpan? tueClose { get; set; }

        [DataMember]
        public TimeSpan? wedOpen { get; set; }

        [DataMember]
        public TimeSpan? wedClose { get; set; }

        [DataMember]
        public TimeSpan? thursOpen { get; set; }

        [DataMember]
        public TimeSpan? thursClose { get; set; }

        [DataMember]
        public TimeSpan? friOpen { get; set; }

        [DataMember]
        public TimeSpan? friClose { get; set; }

        [DataMember]
        public TimeSpan? satOpen { get; set; }

        [DataMember]
        public TimeSpan? satClose { get; set; }

        [DataMember]
        public TimeSpan? sunOpen { get; set; }

        [DataMember]
        public TimeSpan? sunClose { get; set; }

        [DataMember]
        public Applicant Applicant { get; set; }

        [DataMember]
        public List<Job> Jobs { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}