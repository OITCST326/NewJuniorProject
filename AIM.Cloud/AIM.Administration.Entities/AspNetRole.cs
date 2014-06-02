/****************************** Module Header ******************************\
* Module Name:  AspNetRole.cs
* Project:	    A.I.M. - Automated Interview Manager
* Copyright (c) 5 Programers Of Tomorrow.
*
* Asp.Net Role Model.
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
    [Table("AspNetRole")]
    public partial class AspNetRole
    {
        public AspNetRole()
        {
            this.AspNetUsers = new HashSet<AspNetUser>();
        }

        [DataMember]
        [Display(Name = "ASP.NET Role ID")]
        public string Id { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET Role Name")]
        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [DataMember]
        [Display(Name = "ASP.NET Users")]
        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}