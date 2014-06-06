using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Application.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Reference : ITrackable
    {
        [DataMember]
        public int referenceId { get; set; }

        [DataMember]
        public string refFullName { get; set; }

        [DataMember]
        public string refCompany { get; set; }

        [DataMember]
        public string refTitle { get; set; }

        [DataMember]
        public string refPhone { get; set; }

        [DataMember]
        public int? applicantId { get; set; }

        [DataMember]
        public Applicant Applicant { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}