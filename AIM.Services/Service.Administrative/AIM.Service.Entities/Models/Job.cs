using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Job : ITrackable
    {
        public Job()
        {
            this.Applications = new List<Application>();
            this.Employees = new List<Employee>();
            this.OpenJobs = new List<OpenJob>();
        }

        [DataMember]
        public int JobId { get; set; }
        [DataMember]
        public string Position { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string FullPartTime { get; set; }
        [DataMember]
        public string SalaryRange { get; set; }
        [DataMember]
        public Nullable<int> QuestionnaireId { get; set; }
        [DataMember]
        public Nullable<int> HoursId { get; set; }
        [DataMember]
        public Nullable<int> InterviewQuestionId { get; set; }
        [DataMember]
        public List<Application> Applications { get; set; }
        [DataMember]
        public List<Employee> Employees { get; set; }
        [DataMember]
        public Hour Hour { get; set; }
        [DataMember]
        public InterviewQuestion InterviewQuestion { get; set; }
        [DataMember]
        public Questionnaire Questionnaire { get; set; }
        [DataMember]
        public List<OpenJob> OpenJobs { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}
