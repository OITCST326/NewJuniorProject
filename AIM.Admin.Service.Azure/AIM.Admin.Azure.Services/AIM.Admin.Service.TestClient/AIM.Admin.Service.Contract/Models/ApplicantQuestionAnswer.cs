using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;
using TrackableEntities.Client;

namespace AIM.Admin.Service.Contract.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class ApplicantQuestionAnswer : ModelBase<ApplicantQuestionAnswer>, IEquatable<ApplicantQuestionAnswer>, ITrackable
    {
        [DataMember]
        public int AnswerId
        {
            get { return _answerId; }
            set
            {
                if (Equals(value, _answerId)) return;
                _answerId = value;
                NotifyPropertyChanged(m => m.AnswerId);
            }
        }

        private int _answerId;

        [DataMember]
        public Nullable<int> ApplicantId
        {
            get { return _applicantId; }
            set
            {
                if (Equals(value, _applicantId)) return;
                _applicantId = value;
                NotifyPropertyChanged(m => m.ApplicantId);
            }
        }

        private Nullable<int> _applicantId;

        [DataMember]
        public Nullable<int> QuesitonId
        {
            get { return _quesitonId; }
            set
            {
                if (Equals(value, _quesitonId)) return;
                _quesitonId = value;
                NotifyPropertyChanged(m => m.QuesitonId);
            }
        }

        private Nullable<int> _quesitonId;

        [DataMember]
        public string AnswerJsonString
        {
            get { return _answerJsonString; }
            set
            {
                if (Equals(value, _answerJsonString)) return;
                _answerJsonString = value;
                NotifyPropertyChanged(m => m.AnswerJsonString);
            }
        }

        private string _answerJsonString;

        [DataMember]
        public Applicant Applicant
        {
            get { return _applicant; }
            set
            {
                if (Equals(value, _applicant)) return;
                _applicant = value;
                ApplicantChangeTracker = _applicant == null ? null
                    : new ChangeTrackingCollection<Applicant> { _applicant };
                NotifyPropertyChanged(m => m.Applicant);
            }
        }

        private Applicant _applicant;

        private ChangeTrackingCollection<Applicant> ApplicantChangeTracker { get; set; }

        [DataMember]
        public Question Question
        {
            get { return _question; }
            set
            {
                if (Equals(value, _question)) return;
                _question = value;
                QuestionChangeTracker = _question == null ? null
                    : new ChangeTrackingCollection<Question> { _question };
                NotifyPropertyChanged(m => m.Question);
            }
        }

        private Question _question;

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