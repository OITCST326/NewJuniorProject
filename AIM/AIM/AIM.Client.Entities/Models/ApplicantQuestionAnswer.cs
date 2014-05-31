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
    public partial class ApplicantQuestionAnswer : ModelBase<ApplicantQuestionAnswer>, IEquatable<ApplicantQuestionAnswer>, ITrackable
    {
        [DataMember]
        public int answerId
        {
            get { return _answerId; }
            set
            {
                if (Equals(value, _answerId)) return;
                _answerId = value;
                NotifyPropertyChanged(m => m.answerId);
            }
        }

        private int _answerId;

        [DataMember]
        public Nullable<int> applicantId
        {
            get { return _applicantId; }
            set
            {
                if (Equals(value, _applicantId)) return;
                _applicantId = value;
                NotifyPropertyChanged(m => m.applicantId);
            }
        }

        private Nullable<int> _applicantId;

        [DataMember]
        public Nullable<int> quesitonId
        {
            get { return _quesitonId; }
            set
            {
                if (Equals(value, _quesitonId)) return;
                _quesitonId = value;
                NotifyPropertyChanged(m => m.quesitonId);
            }
        }

        private Nullable<int> _quesitonId;

        [DataMember]
        public string answerJsonString
        {
            get { return _answerJsonString; }
            set
            {
                if (Equals(value, _answerJsonString)) return;
                _answerJsonString = value;
                NotifyPropertyChanged(m => m.answerJsonString);
            }
        }

        private string _answerJsonString;

        [DataMember]
        public Applicant Applicant
        {
            get { return _Applicant; }
            set
            {
                if (Equals(value, _Applicant)) return;
                _Applicant = value;
                ApplicantChangeTracker = _Applicant == null ? null
                    : new ChangeTrackingCollection<Applicant> { _Applicant };
                NotifyPropertyChanged(m => m.Applicant);
            }
        }

        private Applicant _Applicant;

        private ChangeTrackingCollection<Applicant> ApplicantChangeTracker { get; set; }

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

        bool IEquatable<ApplicantQuestionAnswer>.Equals(ApplicantQuestionAnswer other)
        {
            if (EntityIdentifier != default(Guid))
                return EntityIdentifier == other.EntityIdentifier;
            return false;
        }

        #endregion Change Tracking
    }
}