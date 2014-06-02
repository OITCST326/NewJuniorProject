/****************************** Module Header ******************************\
* Module Name:  PersonalInfo.cs
* Project:	    A.I.M. - Automated Interview Manager
* Copyright (c) 5 Programers Of Tomorrow.
*
* Personal Info Model.
\***************************************************************************/

namespace AIM.Administration.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true)]
    [Table("PersonalInfo")]
    public partial class PersonalInfo
    {
        public PersonalInfo()
        {
            this.Users = new HashSet<User>();
        }

        [DataMember]
        [Display(Name = "")]
        [Key]
        public int PersonalInfoId { get; set; }

        [DataMember]
        [Display(Name = "Alias")]
        [StringLength(25)]
        public string Alias { get; set; }

        [DataMember]
        [Display(Name = "Street")]
        [StringLength(100)]
        public string Street { get; set; }

        [DataMember]
        [Display(Name = "Street Additional")]
        [StringLength(100)]
        public string Street2 { get; set; }

        [DataMember]
        [Display(Name = "City")]
        [StringLength(50)]
        public string City { get; set; }

        [DataMember]
        [Display(Name = "State")]
        public int? State { get; set; }

        [DataMember]
        [Display(Name = "Zip")]
        [StringLength(5)]
        public string Zip { get; set; }

        [DataMember]
        [Display(Name = "Phone")]
        [StringLength(13)]
        public string Phone { get; set; }

        [DataMember]
        [Display(Name = "User Id")]
        public int? UserId { get; set; }

        [DataMember]
        [Display(Name = "Users")]
        public virtual ICollection<User> Users { get; set; }
    }
}