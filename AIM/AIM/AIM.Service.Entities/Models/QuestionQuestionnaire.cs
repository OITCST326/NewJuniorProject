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
    public partial class QuestionQuestionnaire : ITrackable
    {
        [DataMember]
        [Display(Name = "Question ID")]
        public int questionId { get; set; }

        [DataMember]
        [Display(Name = "Questionnaire ID")]
        public int questionnaireId { get; set; }

        [DataMember]
        [Display(Name = "Number Of Questions")]
        public Nullable<int> numberOfQuestions { get; set; }

        [DataMember]
        [Display(Name = "Questionnaire")]
        public Questionnaire Questionnaire { get; set; }

        [DataMember]
        [Display(Name = "Question")]
        public Question Question { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }
    }
}