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
    public partial class Store : ITrackable
    {
        public Store()
        {
            this.OpenJobs = new List<OpenJob>();
        }

        [DataMember]
        [Display(Name = "Store ID")]
        public int storeId { get; set; }

        [DataMember]
        [Display(Name = "Store Name")]
        public string name { get; set; }

        [DataMember]
        [Display(Name = "Region ID")]
        public Nullable<int> regionId { get; set; }

        [DataMember]
        [Display(Name = "Street")]
        public string street { get; set; }

        [DataMember]
        [Display(Name = "Street2")]
        public string street2 { get; set; }

        [DataMember]
        [Display(Name = "City")]
        public string city { get; set; }

        [DataMember]
        [Display(Name = "State")]
        public Nullable<StateEnum> state { get; set; }

        [DataMember]
        [Display(Name = "Zip Code")]
        public string zip { get; set; }

        [DataMember]
        [Display(Name = "Open Jobs List")]
        public List<OpenJob> OpenJobs { get; set; }

        [DataMember]
        [Display(Name = "Region")]
        public Region Region { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}