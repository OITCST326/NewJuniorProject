/****************************** Module Header ******************************\
* Module Name:  AspNetUserClaim.cs
* Project:	    A.I.M. - Automated Interview Manager
* Copyright (c) 5 Programers Of Tomorrow.
*
* Asp.Net User Claim Model.
\***************************************************************************/

namespace AIM.Application.Entities
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
    [Table("AspNetUserClaim")]
    public partial class AspNetUserClaim
    {
        [DataMember]
        [Display(Name = "ASP.NET User Claim ID")]
        public int Id { get; set; }

        [DataMember]
        [Required]
        [StringLength(128)]
        [Display(Name = "ASP.NET User Claim User ID")]
        public string UserId { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User Claim Type")]
        public string ClaimType { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User Claim Value")]
        public string ClaimValue { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User")]
        public virtual AspNetUser AspNetUser { get; set; }
    }
}