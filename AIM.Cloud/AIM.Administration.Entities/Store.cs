/****************************** Module Header ******************************\
* Module Name:  Store.cs
* Project:	    A.I.M. - Automated Interview Manager
* Copyright (c) 5 Programers Of Tomorrow.
*
* Store Model.
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
    [Table("Store")]
    public partial class Store
    {
        public Store()
        {
            this.OpenJobs = new HashSet<OpenJob>();
        }

        // Store Primary Key
        [DataMember]
        [Display(Name = "Store Id")]
        public int StoreId { get; set; }


        // Store Properties
        [DataMember]
        [Display(Name = "Name")]
        [StringLength(40)]
        public string Name { get; set; }

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
        public StateEnum? State { get; set; }

        [DataMember]
        [Display(Name = "Zip")]
        [StringLength(5)]
        public string Zip { get; set; }


        // Store Table & Column Mappings
        [DataMember]
        [Display(Name = "Open Jobs")]
        public virtual ICollection<OpenJob> OpenJobs { get; set; }

        [DataMember]
        [Display(Name = "Region Id")]
        public int? RegionId { get; set; }

        [DataMember]
        [Display(Name = "Region")]
        public virtual Region Region { get; set; }
    }
}