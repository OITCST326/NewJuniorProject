using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Admin.Service.WorkerRole.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class PersonalInfo : ITrackable
    {
        public PersonalInfo()
        {
            this.Users = new List<User>();
        }

        [DataMember]
        public int PersonalInfoId { get; set; }

        [DataMember]
        public string Alias { get; set; }

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
        public string Phone { get; set; }

        [DataMember]
        public Nullable<int> UserId { get; set; }

        [DataMember]
        public List<User> Users { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}