namespace AIM.Administration.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Education
    {
        public int EducationId { get; set; }

        [StringLength(100)]
        public string SchoolName { get; set; }

        [StringLength(100)]
        public string Degree { get; set; }

        public DateTime? Graduated { get; set; }

        [StringLength(100)]
        public string YearsAttended { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(100)]
        public string Street2 { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        public int? State { get; set; }

        [StringLength(5)]
        public string Zip { get; set; }

        public int? ApplicantId { get; set; }

        public virtual Applicant Applicant { get; set; }
    }
}
