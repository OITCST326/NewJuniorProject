/****************************** Module Header ******************************\
* Module Name:  Reference.cs
* Project:	    A.I.M. - Automated Interview Manager
* Copyright (c) 5 Programers Of Tomorrow.
*
* Reference Model.
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
    [Table("Reference")]
    public partial class Reference
    {
        // Reference Primary Key
        [DataMember]
        [Display(Name = "Reference Id")]
        [Key]
        public int ReferenceId { get; set; }

        // Reference Properties
        [DataMember]
        [Display(Name = "Reference Full Name")]
        [StringLength(50)]
        public string RefFullName { get; set; }

        [DataMember]
        [Display(Name = "Reference Company")]
        [StringLength(50)]
        public string RefCompany { get; set; }

        [DataMember]
        [Display(Name = "Reference Title")]
        [StringLength(50)]
        public string RefTitle { get; set; }

        [DataMember]
        [Display(Name = "Reference Phone")]
        [StringLength(13)]
        public string RefPhone { get; set; }


        // Reference Table & Column Mappings
        [DataMember]
        [Display(Name = "Applicant Id")]
        public int? ApplicantId { get; set; }

        [DataMember]
        [Display(Name = "Applicant")]
        public virtual Applicant Applicant { get; set; }
    }
}