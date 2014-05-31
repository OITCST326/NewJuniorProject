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
    public partial class QuestionQuestionnaire : ModelBase<QuestionQuestionnaire>, IEquatable<QuestionQuestionnaire>, ITrackable
    {
        [DataMember]
        public int questionId
        {
            get { return _questionId; }
            set
            {
                if (Equals(value, _questionId)) return;
                _questionId = value;
                NotifyPropertyChanged(m => m.questionId);
            }
        }

        private int _questionId;

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
        public Nullable<int> numberOfQuestions
        {
            get { return _numberOfQuestions; }
            set
            {
                if (Equals(value, _numberOfQuestions)) return;
                _numberOfQuestions = value;
                NotifyPropertyChanged(m => m.numberOfQuestions);
            }
        }

        private Nullable<int> _numberOfQuestions;

        [DataMember]
        public Questionnaire Questionnaire
        {
            get { return _Questionnaire; }
            set
            {
                if (Equals(value, _Questionnaire)) return;
                _Questionnaire = value;
                QuestionnaireChangeTracker = _Questionnaire == null ? null
                    : new ChangeTrackingCollection<Questionnaire> { _Questionnaire };
                NotifyPropertyChanged(m => m.Questionnaire);
            }
        }

        private Questionnaire _Questionnaire;

        private ChangeTrackingCollection<Questionnaire> QuestionnaireChangeTracker { get; set; }

        [DataMember]
        public Question Question
        {
            get { return _Question; }
            set
            {
                if (Equals(value, _Question)) return;
                _Question = value;
                QuestionChangeTracker = _Question == null ? null
                    : new ChangeTrackingCollection<Question> { _Question };
                NotifyPropertyChanged(m => m.Question);
            }
        }

        private Question _Question;

        private ChangeTrackingCollection<Question> QuestionChangeTracker { get; set; }

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

        bool IEquatable<QuestionQuestionnaire>.Equals(QuestionQuestionnaire other)
        {
            if (EntityIdentifier != default(Guid))
                return EntityIdentifier == other.EntityIdentifier;
            return false;
        }

        #endregion Change Tracking
    }
}