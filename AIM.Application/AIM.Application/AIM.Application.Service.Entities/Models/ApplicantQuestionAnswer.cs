using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Application.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class ApplicantQuestionAnswer : ITrackable
    {
        [DataMember]
        public int answerId { get; set; }

        [DataMember]
        public int? applicantId { get; set; }

        [DataMember]
        public int? quesitonId { get; set; }

        [DataMember]
        public string answerJsonString { get; set; }

        [DataMember]
        public Applicant Applicant { get; set; }

        [DataMember]
        public Question Question { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}