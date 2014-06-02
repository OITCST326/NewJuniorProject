namespace AIM.Application.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Applicant
    {
        public Applicant()
        {
            ApplicantQuestionAnswers = new HashSet<ApplicantQuestionAnswer>();
            Applications = new HashSet<Application>();
            Educations = new HashSet<Education>();
            JobHistories = new HashSet<JobHistory>();
            Hours = new HashSet<Hour>();
            References = new HashSet<Reference>();
            Users = new HashSet<User>();
        }

        public int ApplicantId { get; set; }

        public int? EducationId { get; set; }

        public int? JobHistoryId { get; set; }

        public int? ReferenceId { get; set; }

        public int? UserId { get; set; }

        public int? ApplicationId { get; set; }

        public int? AnswerId { get; set; }

        public int? HoursId { get; set; }

        public virtual ICollection<ApplicantQuestionAnswer> ApplicantQuestionAnswers { get; set; }

        public virtual ICollection<Application> Applications { get; set; }

        public virtual ICollection<Education> Educations { get; set; }

        public virtual ICollection<JobHistory> JobHistories { get; set; }

        public virtual ICollection<Hour> Hours { get; set; }

        public virtual ICollection<Reference> References { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
