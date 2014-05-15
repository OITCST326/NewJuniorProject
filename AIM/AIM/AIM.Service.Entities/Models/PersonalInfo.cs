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
    public partial class PersonalInfo : ITrackable
    {
        public PersonalInfo()
        {
            this.Users = new List<User>();
        }

        [DataMember]
        [Display(Name = "Personal Info ID")]
        public int PersonalInfoId { get; set; }

        [DataMember]
        [Display(Name = "Alias")]
        public string alias { get; set; }

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
        [Display(Name = "Phone Number")]
        public string phone { get; set; }

        [DataMember]
        [Display(Name = "User ID")]
        public Nullable<int> userId { get; set; }

        [DataMember]
        [Display(Name = "Users List")]
        public List<User> Users { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}