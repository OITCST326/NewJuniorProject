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
    public partial class OpenJob : ITrackable
    {
        [DataMember]
        [Display(Name = "Open Jobs ID")]
        public int openJobsId { get; set; }

        [DataMember]
        [Display(Name = "Job ID")]
        public int jobId { get; set; }

        [DataMember]
        [Display(Name = "Store ID")]
        public int storeId { get; set; }

        [DataMember]
        [Display(Name = "Region ID")]
        public int regionId { get; set; }

        [DataMember]
        [Display(Name = "Approved")]
        public bool isApproved { get; set; }

        [DataMember]
        [Display(Name = "Job")]
        public Job Job { get; set; }

        [DataMember]
        [Display(Name = "Store")]
        public Store Store { get; set; }

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