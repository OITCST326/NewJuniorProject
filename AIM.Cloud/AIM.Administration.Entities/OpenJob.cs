/****************************** Module Header ******************************\
* Module Name:  OpenJob.cs
* Project:	    A.I.M. - Automated Interview Manager
* Copyright (c) 5 Programers Of Tomorrow.
*
* Open Job Model.
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
    [Table("OpenJob")]
    public partial class OpenJob
    {
        // Open Job Primary Key
        [DataMember]
        [Display(Name = "Open Jobs Id")]
        [Key]
        public int OpenJobsId { get; set; }

        // Open Jobs Properties
        [DataMember]
        [Display(Name = "Is Approved")]
        public bool? IsApproved { get; set; }


        // Open Job Table & Column Mappings
        [DataMember]
        [Display(Name = "Job Id")]
        public int JobId { get; set; }

        [DataMember]
        [Display(Name = "Store Id")]
        public int StoreId { get; set; }

        [DataMember]
        [Display(Name = "Region Id")]
        public int RegionId { get; set; }

        [DataMember]
        [Display(Name = "Job")]
        public virtual Job Job { get; set; }

        [DataMember]
        [Display(Name = "Store")]
        public virtual Store Store { get; set; }

        [DataMember]
        [Display(Name = "Region")]
        public virtual Region Region { get; set; }
    }
}