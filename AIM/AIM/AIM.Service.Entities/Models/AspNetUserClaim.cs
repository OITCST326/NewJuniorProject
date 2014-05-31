using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class AspNetUserClaim : ITrackable
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public string ClaimType { get; set; }
        [DataMember]
        public string ClaimValue { get; set; }
        [DataMember]
        public AspNetUser AspNetUser { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}
