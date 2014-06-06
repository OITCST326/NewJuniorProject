using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;

namespace AIM.Application.Service.Entities.Models
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
        public int jobId { get; set; }

        [DataMember]
        public string position { get; set; }

        [DataMember]
        public string description { get; set; }

        [DataMember]
        public string fullPartTime { get; set; }

        [DataMember]
        public string salaryRange { get; set; }

        [DataMember]
        public int? questionnaireId { get; set; }

        [DataMember]
        public int? hoursId { get; set; }

        [DataMember]
        public int? InterviewQuestionId { get; set; }

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
    }
}