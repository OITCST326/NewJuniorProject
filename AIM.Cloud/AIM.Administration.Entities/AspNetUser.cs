/****************************** Module Header ******************************\
* Module Name:  AspNetUser.cs
* Project:	    A.I.M. - Automated Interview Manager
* Copyright (c) 5 Programers Of Tomorrow.
*
* Asp.Net User Model.
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
    [Table("AspNetUser")]
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            this.AspNetUserClaims = new HashSet<AspNetUserClaim>();
            this.AspNetUserLogins = new HashSet<AspNetUserLogin>();
            this.Users = new HashSet<User>();
            this.AspNetRoles = new HashSet<AspNetRole>();
        }

        [DataMember]
        [Display(Name = "ASP.NET User ID")]
        public string Id { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User Email")]
        [StringLength(256)]
        public string Email { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User Email Confirmed")]
        public bool EmailConfirmed { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User Password Hash")]
        public string PasswordHash { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User Security Stamp")]
        public string SecurityStamp { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User Phone Number")]
        public string PhoneNumber { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User Phone Number Confirmed")]
        public bool PhoneNumberConfirmed { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User Two Factor Enabled")]
        public bool TwoFactorEnabled { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User Lockout End Date Utc")]
        public DateTime? LockoutEndDateUtc { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User Lockout Enabled")]
        public bool LockoutEnabled { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User Access Failed Count")]
        public int AccessFailedCount { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User Access Failed Count")]
        [Required]
        [StringLength(256)]
        public string UserName { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User Claims")]
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User Logins")]
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET Users")]
        public virtual ICollection<User> Users { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET Roles")]
        public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
    }
}