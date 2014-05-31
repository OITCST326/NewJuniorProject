using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Service.Entities.Models
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
        [Display(Name = "Region ID")]
        public int regionId { get; set; }

        [DataMember]
        [Display(Name = "Region Name")]
        public string regionName { get; set; }

        [DataMember]
        [Display(Name = "Open Jobs List")]
        public List<OpenJob> OpenJobs { get; set; }

        [DataMember]
        [Display(Name = "Stores")]
        public List<Store> Stores { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}