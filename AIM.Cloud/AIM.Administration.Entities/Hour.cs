namespace AIM.Administration.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hour
    {
        public Hour()
        {
            Jobs = new HashSet<Job>();
        }

        [Key]
        public int HoursId { get; set; }

        public int? ApplicantId { get; set; }

        public TimeSpan? MonOpen { get; set; }

        public TimeSpan? MonClose { get; set; }

        public TimeSpan? TueOpen { get; set; }

        public TimeSpan? TueClose { get; set; }

        public TimeSpan? WedOpen { get; set; }

        public TimeSpan? WedClose { get; set; }

        public TimeSpan? ThursOpen { get; set; }

        public TimeSpan? ThursClose { get; set; }

        public TimeSpan? FriOpen { get; set; }

        public TimeSpan? FriClose { get; set; }

        public TimeSpan? SatOpen { get; set; }

        public TimeSpan? SatClose { get; set; }

        public TimeSpan? SunOpen { get; set; }

        public TimeSpan? SunClose { get; set; }

        public virtual Applicant Applicant { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}
