using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Applicant : ITrackable
    {
        public Applicant()
        {
            this.ApplicantQuestionAnswers = new List<ApplicantQuestionAnswer>();
            this.Applications = new List<Application>();
            this.Educations = new List<Education>();
            this.JobHistories = new List<JobHistory>();
            this.Hours = new List<Hour>();
            this.References = new List<Reference>();
            this.Users = new List<User>();
        }

        [DataMember]
        [Display(Name = "Applicant ID")]
        public int applicantId { get; set; }

        [DataMember]
        [Display(Name = "Education ID")]
        public Nullable<int> educationId { get; set; }

        [DataMember]
        [Display(Name = "Job History ID")]
        public Nullable<int> jobHistoryId { get; set; }

        [DataMember]
        [Display(Name = "Reference ID")]
        public Nullable<int> referenceId { get; set; }

        [DataMember]
        [Display(Name = "User ID")]
        public Nullable<int> userId { get; set; }

        [DataMember]
        [Display(Name = "Application ID")]
        public Nullable<int> applicationId { get; set; }

        [DataMember]
        [Display(Name = "Answer ID")]
        public Nullable<int> answerId { get; set; }

        [DataMember]
        [Display(Name = "Hours ID")]
        public Nullable<int> hoursId { get; set; }

        [DataMember]
        [Display(Name = "Applicant Question Answers List")]
        public List<ApplicantQuestionAnswer> ApplicantQuestionAnswers { get; set; }

        [DataMember]
        [Display(Name = "Applications List")]
        public List<Application> Applications { get; set; }

        [DataMember]
        [Display(Name = "Educations List")]
        public List<Education> Educations { get; set; }

        [DataMember]
        [Display(Name = "Job Histories list")]
        public List<JobHistory> JobHistories { get; set; }

        [DataMember]
        [Display(Name = "Hours List")]
        public List<Hour> Hours { get; set; }

        [DataMember]
        [Display(Name = "References List")]
        public List<Reference> References { get; set; }

        [DataMember]
        [Display(Name = "Users List")]
        public List<User> Users { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}