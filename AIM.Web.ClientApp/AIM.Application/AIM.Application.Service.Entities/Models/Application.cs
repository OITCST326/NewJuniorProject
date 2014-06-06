using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Application.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Application : ITrackable
    {
        [DataMember]
        public int applicationId { get; set; }

        [DataMember]
        public int? applicantId { get; set; }

        [DataMember]
        public DateTime? dateCreated { get; set; }

        [DataMember]
        public string preEmploymentStatement { get; set; }

        [DataMember]
        public int? jobId { get; set; }

        [DataMember]
        public StatusEnum? status { get; set; }

        [DataMember]
        public string salaryExpectation { get; set; }

        [DataMember]
        public bool? isFullTime { get; set; }

        [DataMember]
        public bool? isDays { get; set; }

        [DataMember]
        public bool? isEvenings { get; set; }

        [DataMember]
        public bool? isWeekends { get; set; }

        [DataMember]
        public Applicant Applicant { get; set; }

        [DataMember]
        public Job Job { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}