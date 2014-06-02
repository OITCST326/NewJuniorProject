namespace AIM.Administration.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Job
    {
        public Job()
        {
            Applications = new HashSet<Application>();
            Employees = new HashSet<Employee>();
            OpenJobs = new HashSet<OpenJob>();
        }

        public int JobId { get; set; }

        [StringLength(150)]
        public string Position { get; set; }

        public string Description { get; set; }

        [StringLength(50)]
        public string FullPartTime { get; set; }

        [StringLength(100)]
        public string SalaryRange { get; set; }

        public int? QuestionnaireId { get; set; }

        public int? HoursId { get; set; }

        public int? InterviewQuestionId { get; set; }

        public virtual ICollection<Application> Applications { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public virtual Hour Hour { get; set; }

        public virtual InterviewQuestion InterviewQuestion { get; set; }

        public virtual Questionnaire Questionnaire { get; set; }

        public virtual ICollection<OpenJob> OpenJobs { get; set; }
    }
}
