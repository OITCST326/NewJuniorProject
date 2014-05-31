using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Application.Service.Entities.Models
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
        public string alias { get; set; }

        [DataMember]
        public string street { get; set; }

        [DataMember]
        public string street2 { get; set; }

        [DataMember]
        public string city { get; set; }

        [DataMember]
        public StateEnum? state { get; set; }

        [DataMember]
        public string zip { get; set; }

        [DataMember]
        public string phone { get; set; }

        [DataMember]
        public int? userId { get; set; }

        [DataMember]
        public List<User> Users { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}