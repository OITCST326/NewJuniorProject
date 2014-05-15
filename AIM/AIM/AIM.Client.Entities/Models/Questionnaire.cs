using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;
using TrackableEntities.Client;

namespace AIM.Client.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Questionnaire : ModelBase<Questionnaire>, ITrackable
    {
        public Questionnaire()
        {
            this.Jobs = new ChangeTrackingCollection<Job>();
            this.QuestionQuestionnaires = new ChangeTrackingCollection<QuestionQuestionnaire>();
        }

        [DataMember]
        public int questionnaireId
        {
            get { return _questionnaireId; }
            set
            {
                if (value == _questionnaireId) return;
                _questionnaireId = value;
                NotifyPropertyChanged(m => m.questionnaireId);
            }
        }

        private int _questionnaireId;

        [DataMember]
        public Nullable<int> questionId
        {
            get { return _questionId; }
            set
            {
                if (value == _questionId) return;
                _questionId = value;
                NotifyPropertyChanged(m => m.questionId);
            }
        }

        private Nullable<int> _questionId;

        [DataMember]
        public Nullable<int> jobId
        {
            get { return _jobId; }
            set
            {
                if (value == _jobId) return;
                _jobId = value;
                NotifyPropertyChanged(m => m.jobId);
            }
        }

        private Nullable<int> _jobId;

        [DataMember]
        public ChangeTrackingCollection<Job> Jobs
        {
            get { return _Jobs; }
            set
            {
                if (Equals(value, _Jobs)) return;
                _Jobs = value;
                NotifyPropertyChanged(m => m.Jobs);
            }
        }

        private ChangeTrackingCollection<Job> _Jobs;

        [DataMember]
        public ChangeTrackingCollection<QuestionQuestionnaire> QuestionQuestionnaires
        {
            get { return _QuestionQuestionnaires; }
            set
            {
                if (Equals(value, _QuestionQuestionnaires)) return;
                _QuestionQuestionnaires = value;
                NotifyPropertyChanged(m => m.QuestionQuestionnaires);
            }
        }

        private ChangeTrackingCollection<QuestionQuestionnaire> _QuestionQuestionnaires;

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
    }
}