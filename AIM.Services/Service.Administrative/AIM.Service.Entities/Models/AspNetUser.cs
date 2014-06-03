using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class AspNetUser : ITrackable
    {
        public AspNetUser()
        {
            this.AspNetUserClaims = new List<AspNetUserClaim>();
            this.AspNetUserLogins = new List<AspNetUserLogin>();
            this.Users = new List<User>();
            this.AspNetRoles = new List<AspNetRole>();
        }

        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public bool EmailConfirmed { get; set; }
        [DataMember]
        public string PasswordHash { get; set; }
        [DataMember]
        public string SecurityStamp { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public bool PhoneNumberConfirmed { get; set; }
        [DataMember]
        public bool TwoFactorEnabled { get; set; }
        [DataMember]
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        [DataMember]
        public bool LockoutEnabled { get; set; }
        [DataMember]
        public int AccessFailedCount { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public List<AspNetUserClaim> AspNetUserClaims { get; set; }
        [DataMember]
        public List<AspNetUserLogin> AspNetUserLogins { get; set; }
        [DataMember]
        public List<User> Users { get; set; }
        [DataMember]
        public List<AspNetRole> AspNetRoles { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}
