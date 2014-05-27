using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Admin.Service.WorkerRole.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Store : ITrackable
    {
        public Store()
        {
            this.OpenJobs = new List<OpenJob>();
        }

        [DataMember]
        public int StoreId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public Nullable<int> RegionId { get; set; }

        [DataMember]
        public string Street { get; set; }

        [DataMember]
        public string Street2 { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public Nullable<StateEnum> State { get; set; }

        [DataMember]
        public string Zip { get; set; }

        [DataMember]
        public List<OpenJob> OpenJobs { get; set; }

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