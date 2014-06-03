using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;

namespace AIM.Service.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Questionnaire : ITrackable
    {
        public Questionnaire()
        {
            this.Jobs = new List<Job>();
            this.Questions = new List<Question>();
        }

        [DataMember]
        public int QuestionnaireId { get; set; }
        [DataMember]
        public Nullable<int> QuestionId { get; set; }
        [DataMember]
        public Nullable<int> JobId { get; set; }
        [DataMember]
        public List<Job> Jobs { get; set; }
        [DataMember]
        public List<Question> Questions { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}
