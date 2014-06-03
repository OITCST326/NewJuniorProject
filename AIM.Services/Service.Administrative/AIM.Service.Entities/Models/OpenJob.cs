using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class OpenJob : ITrackable
    {
        [DataMember]
        public int OpenJobsId { get; set; }
        [DataMember]
        public int JobId { get; set; }
        [DataMember]
        public int StoreId { get; set; }
        [DataMember]
        public int RegionId { get; set; }
        [DataMember]
        public Nullable<bool> IsApproved { get; set; }
        [DataMember]
        public Job Job { get; set; }
        [DataMember]
        public Store Store { get; set; }
        [DataMember]
        public Region Region { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}
