using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Admin.Service.WorkerRole.Models
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
        public int ApplicantId { get; set; }

        [DataMember]
        [Display(Name = "Education ID")]
        public Nullable<int> EducationId { get; set; }

        [DataMember]
        [Display(Name = "Job History ID")]
        public Nullable<int> JobHistoryId { get; set; }

        [DataMember]
        [Display(Name = "Reference ID")]
        public Nullable<int> ReferenceId { get; set; }

        [DataMember]
        [Display(Name = "User ID")]
        public Nullable<int> UserId { get; set; }

        [DataMember]
        [Display(Name = "Application ID")]
        public Nullable<int> ApplicationId { get; set; }

        [DataMember]
        [Display(Name = "Answer ID")]
        public Nullable<int> AnswerId { get; set; }

        [DataMember]
        [Display(Name = "Hours ID")]
        public Nullable<int> HoursId { get; set; }

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
        [Display(Name = "Job Histories List")]
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