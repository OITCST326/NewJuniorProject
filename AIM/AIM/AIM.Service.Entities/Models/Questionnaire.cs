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
    public partial class Questionnaire : ITrackable
    {
        public Questionnaire()
        {
            this.Jobs = new List<Job>();
            this.QuestionQuestionnaires = new List<QuestionQuestionnaire>();
        }

        [DataMember]
        [Display(Name = "Questionnaire ID")]
        public int questionnaireId { get; set; }

        [DataMember]
        [Display(Name = "Question ID")]
        public Nullable<int> questionId { get; set; }

        [DataMember]
        [Display(Name = "Job ID")]
        public Nullable<int> jobId { get; set; }

        [DataMember]
        [Display(Name = "Jobs List")]
        public List<Job> Jobs { get; set; }

        [DataMember]
        [Display(Name = "Question Questionnaires List")]
        public List<QuestionQuestionnaire> QuestionQuestionnaires { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}