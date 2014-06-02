namespace AIM.Application.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reference
    {
        public int ReferenceId { get; set; }

        [StringLength(50)]
        public string RefFullName { get; set; }

        [StringLength(50)]
        public string RefCompany { get; set; }

        [StringLength(50)]
        public string RefTitle { get; set; }

        [StringLength(13)]
        public string RefPhone { get; set; }

        public int? ApplicantId { get; set; }

        public virtual Applicant Applicant { get; set; }
    }
}
