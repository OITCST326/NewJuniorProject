/****************************** Module Header ******************************\
* Module Name:  InterviewQuestion.cs
* Project:	    A.I.M. - Automated Interview Manager
* Copyright (c) 5 Programers Of Tomorrow.
*
* Interview Question Model.
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
    [Table("InterviewQuestion")]
    public partial class InterviewQuestion
    {
        public InterviewQuestion()
        {
            this.Jobs = new HashSet<Job>();
            this.Questions = new HashSet<Question>();
        }

        // Interview Question Primary Key
        [DataMember]
        [Display(Name = "Interview Question Id")]
        [Key]
        public int InterviewQuestionsId { get; set; }


        // Interview Question Table & Column Mappings
        [DataMember]
        [Display(Name = "Question Id")]
        public int? QuestionId { get; set; }

        [DataMember]
        [Display(Name = "Job Id")]
        public int? JobId { get; set; }

        [DataMember]
        [Display(Name = "Job")]
        public virtual ICollection<Job> Jobs { get; set; }

        [DataMember]
        [Display(Name = "Question")]
        public virtual ICollection<Question> Questions { get; set; }
    }
}