/****************************** Module Header ******************************\
* Module Name:  Job.cs
* Project:	    A.I.M. - Automated Interview Manager
* Copyright (c) 5 Programers Of Tomorrow.
*
* Job Model.
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
    [Table("Job")]
    public partial class Job
    {
        public Job()
        {
            this.Applications = new HashSet<Application>();
            this.Employees = new HashSet<Employee>();
            this.OpenJobs = new HashSet<OpenJob>();
        }

        // Job Primary Key
        [DataMember]
        [Display(Name = "Job Id")]
        [Key]
        public int JobId { get; set; }


        // Employee Properties
        [DataMember]
        [Display(Name = "Position")]
        [StringLength(150)]
        public string Position { get; set; }

        [DataMember]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [DataMember]
        [Display(Name = "Full/Part Time")]
        [StringLength(50)]
        public string FullPartTime { get; set; }

        [DataMember]
        [Display(Name = "Salary Range")]
        [StringLength(100)]
        public string SalaryRange { get; set; }


        // Job Table & Column Mappings
        [DataMember]
        [Display(Name = "Questionnaire Id")]
        public int? QuestionnaireId { get; set; }

        [DataMember]
        [Display(Name = "Hours Id")]
        public int? HoursId { get; set; }

        [DataMember]
        [Display(Name = "Interview Question Id")]
        public int? InterviewQuestionId { get; set; }

        [DataMember]
        [Display(Name = "Application")]
        public virtual ICollection<Application> Applications { get; set; }

        [DataMember]
        [Display(Name = "Employees")]
        public virtual ICollection<Employee> Employees { get; set; }

        [DataMember]
        [Display(Name = "Hour")]
        public virtual Hour Hour { get; set; }

        [DataMember]
        [Display(Name = "Interview Question")]
        public virtual InterviewQuestion InterviewQuestion { get; set; }

        [DataMember]
        [Display(Name = "Questionnaire")]
        public virtual Questionnaire Questionnaire { get; set; }

        [DataMember]
        [Display(Name = "Open Job")]
        public virtual ICollection<OpenJob> OpenJobs { get; set; }
    }
}