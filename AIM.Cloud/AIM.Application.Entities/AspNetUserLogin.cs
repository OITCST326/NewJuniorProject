/****************************** Module Header ******************************\
* Module Name:  AspNetUserLogin.cs
* Project:	    A.I.M. - Automated Interview Manager
* Copyright (c) 5 Programers Of Tomorrow.
*
* Asp.Net User Login Model.
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
    [Table("AspNetUserLogin")]
    public partial class AspNetUserLogin
    {
        [DataMember]
        [Display(Name = "ASP.NET User Login Provider")]
        [Key]
        [Column(Order = 0)]
        public string LoginProvider { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User Provider Key")]
        [Key]
        [Column(Order = 1)]
        public string ProviderKey { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User Id")]
        [Key]
        [Column(Order = 2)]
        public string UserId { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET User")]
        public virtual AspNetUser AspNetUser { get; set; }
    }
}