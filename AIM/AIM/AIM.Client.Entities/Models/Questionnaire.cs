using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;
using TrackableEntities.Client;

namespace AIM.Client.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Questionnaire : ModelBase<Questionnaire>, IEquatable<Questionnaire>, ITrackable
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
                if (Equals(value, _questionnaireId)) return;
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
                if (Equals(value, _questionId)) return;
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
                if (Equals(value, _jobId)) return;
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

        #region Change Tracking

        [DataMember]
        public TrackingState TrackingState { get; set; }

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [JsonProperty, DataMember]
        private Guid EntityIdentifier { get; set; }

#pragma warning disable 414

        [JsonProperty, DataMember]
        private Guid _entityIdentity = default(Guid);

#pragma warning restore 414

        bool IEquatable<Questionnaire>.Equals(Questionnaire other)
        {
            if (EntityIdentifier != default(Guid))
                return EntityIdentifier == other.EntityIdentifier;
            return false;
        }

        #endregion Change Tracking
    }
}