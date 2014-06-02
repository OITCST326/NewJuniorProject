namespace AIM.Application.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ApplicantQuestionAnswer
    {
        [Key]
        public int AnswerId { get; set; }

        public int? ApplicantId { get; set; }

        public int? QuesitonId { get; set; }

        public string AnswerJsonString { get; set; }

        public virtual Applicant Applicant { get; set; }

        public virtual Question Question { get; set; }
    }
}
