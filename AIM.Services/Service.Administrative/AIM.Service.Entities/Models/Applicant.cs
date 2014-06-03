using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
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
        public int ApplicantId { get; set; }
        [DataMember]
        public Nullable<int> EducationId { get; set; }
        [DataMember]
        public Nullable<int> JobHistoryId { get; set; }
        [DataMember]
        public Nullable<int> ReferenceId { get; set; }
        [DataMember]
        public Nullable<int> UserId { get; set; }
        [DataMember]
        public Nullable<int> ApplicationId { get; set; }
        [DataMember]
        public Nullable<int> AnswerId { get; set; }
        [DataMember]
        public Nullable<int> HoursId { get; set; }
        [DataMember]
        public List<ApplicantQuestionAnswer> ApplicantQuestionAnswers { get; set; }
        [DataMember]
        public List<Application> Applications { get; set; }
        [DataMember]
        public List<Education> Educations { get; set; }
        [DataMember]
        public List<JobHistory> JobHistories { get; set; }
        [DataMember]
        public List<Hour> Hours { get; set; }
        [DataMember]
        public List<Reference> References { get; set; }
        [DataMember]
        public List<User> Users { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}
