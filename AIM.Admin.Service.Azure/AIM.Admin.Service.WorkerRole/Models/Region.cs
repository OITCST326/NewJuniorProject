using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Admin.Service.WorkerRole.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Region : ITrackable
    {
        public Region()
        {
            this.OpenJobs = new List<OpenJob>();
            this.Stores = new List<Store>();
        }

        [DataMember]
        public int RegionId { get; set; }

        [DataMember]
        public string RegionName { get; set; }

        [DataMember]
        public List<OpenJob> OpenJobs { get; set; }

        [DataMember]
        public List<Store> Stores { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}