namespace AIM.Application.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Application
    {
        public int ApplicationId { get; set; }

        public int? ApplicantId { get; set; }

        public DateTime? DateCreated { get; set; }

        [StringLength(100)]
        public string PreEmploymentStatement { get; set; }

        public int? JobId { get; set; }

        public int? Status { get; set; }

        [StringLength(20)]
        public string SalaryExpectation { get; set; }

        public bool? IsFullTime { get; set; }

        public bool? IsDays { get; set; }

        public bool? IsEvenings { get; set; }

        public bool? IsWeekends { get; set; }

        public virtual Applicant Applicant { get; set; }

        public virtual Job Job { get; set; }
    }
}
