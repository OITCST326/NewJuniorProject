/****************************** Module Header ******************************\
* Module Name:  Region.cs
* Project:	    A.I.M. - Automated Interview Manager
* Copyright (c) 5 Programers Of Tomorrow.
*
* Region Model.
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
    [Table("Region")]
    public partial class Region
    {
        public Region()
        {
            this.OpenJobs = new HashSet<OpenJob>();
            this.Stores = new HashSet<Store>();
        }

        // Region Primary Key
        [DataMember]
        [Display(Name = "Region Id")]
        [Key]
        public int RegionId { get; set; }


        // Region Properties
        [DataMember]
        [Display(Name = "Region Name")]
        [StringLength(40)]
        public string RegionName { get; set; }


        // Region Table & Column Mappings
        [DataMember]
        [Display(Name = "Open Jobs")]
        public virtual ICollection<OpenJob> OpenJobs { get; set; }

        [DataMember]
        [Display(Name = "Stores")]
        public virtual ICollection<Store> Stores { get; set; }
    }
}