/****************************** Module Header ******************************\
* Module Name:  Applicant.cs
* Project:	    A.I.M. - Automated Interview Manager
* Copyright (c) 5 Programers Of Tomorrow.
*
* Applicant Model.
\***************************************************************************/

namespace AIM.Application.Entities
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
    [Table("Applicant")]
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

        // Applicant Primary Key
        [DataMember]
        [Display(Name = "Applicant ID")]
        public int ApplicantId { get; set; }


        // Applicant Table & Column Mappings
        [DataMember]
        [Display(Name = "Education ID")]
        public int? EducationId { get; set; }

        [DataMember]
        [Display(Name = "Job History ID")]
        public int? JobHistoryId { get; set; }

        [DataMember]
        [Display(Name = "Reference ID")]
        public int? ReferenceId { get; set; }

        [DataMember]
        [Display(Name = "User ID")]
        public int? UserId { get; set; }

        [DataMember]
        [Display(Name = "Application ID")]
        public int? ApplicationId { get; set; }

        [DataMember]
        [Display(Name = "Answer ID")]
        public int? AnswerId { get; set; }

        [DataMember]
        [Display(Name = "Hours ID")]
        public int? HoursId { get; set; }

        [DataMember]
        [Display(Name = "Applicant Question Answers List")]
        public virtual ICollection<ApplicantQuestionAnswer> ApplicantQuestionAnswers { get; set; }

        [DataMember]
        [Display(Name = "Applications List")]
        public virtual ICollection<Application> Applications { get; set; }

        [DataMember]
        [Display(Name = "Educations List")]
        public virtual ICollection<Education> Educations { get; set; }

        [DataMember]
        [Display(Name = "Job Histories list")]
        public virtual ICollection<JobHistory> JobHistories { get; set; }

        [DataMember]
        [Display(Name = "Hours List")]
        public virtual ICollection<Hour> Hours { get; set; }

        [DataMember]
        [Display(Name = "References List")]
        public virtual ICollection<Reference> References { get; set; }

        [DataMember]
        [Display(Name = "Users List")]
        public virtual ICollection<User> Users { get; set; }
    }
}
