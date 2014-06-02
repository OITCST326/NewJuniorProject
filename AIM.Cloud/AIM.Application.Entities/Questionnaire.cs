namespace AIM.Application.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Questionnaire
    {
        public Questionnaire()
        {
            Jobs = new HashSet<Job>();
            Questions = new HashSet<Question>();
        }

        public int QuestionnaireId { get; set; }

        public int? QuestionId { get; set; }

        public int? JobId { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
