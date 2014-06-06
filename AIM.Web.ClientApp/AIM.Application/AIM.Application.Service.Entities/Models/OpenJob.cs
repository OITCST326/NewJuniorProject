using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Application.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class OpenJob : ITrackable
    {
        [DataMember]
        public int openJobsId { get; set; }

        [DataMember]
        public int jobId { get; set; }

        [DataMember]
        public int storeId { get; set; }

        [DataMember]
        public int regionId { get; set; }

        [DataMember]
        public bool? isApproved { get; set; }

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
    }
}