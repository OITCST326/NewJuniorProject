using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class ApplicantQuestionAnswer : ITrackable
    {
        [DataMember]
        public int AnswerId { get; set; }
        [DataMember]
        public Nullable<int> ApplicantId { get; set; }
        [DataMember]
        public Nullable<int> QuesitonId { get; set; }
        [DataMember]
        public string AnswerJsonString { get; set; }
        [DataMember]
        public Applicant Applicant { get; set; }
        [DataMember]
        public Question Question { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}
