namespace AIM.Application.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class JobHistory
    {
        public int JobHistoryId { get; set; }

        [StringLength(50)]
        public string EmployerName { get; set; }

        [StringLength(50)]
        public string Position { get; set; }

        public string Responsibilities { get; set; }

        [StringLength(50)]
        public string Supervisor { get; set; }

        public decimal? StartingSalary { get; set; }

        public decimal? EndingSalary { get; set; }

        public string ReasonForLeaving { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(100)]
        public string Street2 { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        public int? State { get; set; }

        [StringLength(5)]
        public string Zip { get; set; }

        [StringLength(13)]
        public string Phone { get; set; }

        public int? ApplicantId { get; set; }

        public virtual Applicant Applicant { get; set; }
    }
}
