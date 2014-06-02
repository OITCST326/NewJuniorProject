/****************************** Module Header ******************************\
* Module Name:  Questionnaire.cs
* Project:	    A.I.M. - Automated Interview Manager
* Copyright (c) 5 Programers Of Tomorrow.
*
* Questionnaire Model.
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
    [Table("Questionnaire")]
    public partial class Questionnaire
    {
        public Questionnaire()
        {
            this.Jobs = new HashSet<Job>();
            this.Questions = new HashSet<Question>();
        }

        // Questionnaire Primary Key
        [DataMember]
        [Display(Name = "Questionnaire Id")]
        public int QuestionnaireId { get; set; }


        // Question Table & Column Mappings
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
        [Display(Name = "Questions")]
        public virtual ICollection<Question> Questions { get; set; }
    }
}