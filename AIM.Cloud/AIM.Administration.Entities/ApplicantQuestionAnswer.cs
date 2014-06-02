/****************************** Module Header ******************************\
* Module Name:  ApplicantQuestionAnswer.cs
* Project:	    A.I.M. - Automated Interview Manager
* Copyright (c) 5 Programers Of Tomorrow.
*
* Applicant Question Answer Model.
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
    [Table("ApplicationQuestionAnswer")]
    public partial class ApplicantQuestionAnswer
    {
        public ApplicantQuestionAnswer()
        {
            this.AnsweredQJsonOptionList = new List<string>();
            this.AnsweredQJsonAnswersList = new List<string>();
        }

        // Applicant Question Answer Primary Key
        [DataMember]
        [Display(Name = "Answer ID")]
        [Key]
        public int AnswerId { get; set; }


        // Applicant Question Answer Properties
        [DataMember]
        [Display(Name = "Answer Json String")]
        public string AnswerJsonString { get; set; }


        // Applicant Question Answer Table & Column Mappings
        [DataMember]
        [Display(Name = "Applicant ID")]
        public int? ApplicantId { get; set; }

        [DataMember]
        [Display(Name = "Question ID")]
        public int? QuesitonId { get; set; }

        [DataMember]
        [Display(Name = "Applicant")]
        public virtual Applicant Applicant { get; set; }

        [DataMember]
        [Display(Name = "Question")]
        public virtual Question Question { get; set; }


        // JSON working properties to deserialize QJsonProperties JSON String

        // JSON working property for Answered Question Id
        [JsonProperty, DataMember]
        [Display(Name = "Question Id")]
        public int? AnsweredQJsonId { get; set; }

        // JSON working property for Answered Question Type
        [JsonProperty, DataMember]
        [Display(Name = "Question Type")]
        public TypeEnum? AnsweredQJsonType { get; set; }

        // JSON working property for Answered Question Text
        [JsonProperty, DataMember]
        [Display(Name = "Question")]
        public string AnsweredQJsonText { get; set; }

        // JSON working list property for Answered Question Options List
        [JsonProperty, DataMember]
        [Display(Name = "Question Options")]
        public IList<string> AnsweredQJsonOptionList { get; set; }

        // JSON working list property for Answered Question Answers List
        [JsonProperty, DataMember]
        [Display(Name = "Desired Answer(s)")]
        public IList<string> AnsweredQJsonAnswersList { get; set; }
    }
}