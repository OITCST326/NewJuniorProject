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
    public partial class QuestionInterviewQuestionMapping : ModelBase<QuestionInterviewQuestionMapping>, IEquatable<QuestionInterviewQuestionMapping>, ITrackable
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
        public int interviewQuestionsId
        {
            get { return _interviewQuestionsId; }
            set
            {
                if (Equals(value, _interviewQuestionsId)) return;
                _interviewQuestionsId = value;
                NotifyPropertyChanged(m => m.interviewQuestionsId);
            }
        }

        private int _interviewQuestionsId;

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
        public InterviewQuestion InterviewQuestion
        {
            get { return _InterviewQuestion; }
            set
            {
                if (Equals(value, _InterviewQuestion)) return;
                _InterviewQuestion = value;
                InterviewQuestionChangeTracker = _InterviewQuestion == null ? null
                    : new ChangeTrackingCollection<InterviewQuestion> { _InterviewQuestion };
                NotifyPropertyChanged(m => m.InterviewQuestion);
            }
        }

        private InterviewQuestion _InterviewQuestion;

        private ChangeTrackingCollection<InterviewQuestion> InterviewQuestionChangeTracker { get; set; }

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

        bool IEquatable<QuestionInterviewQuestionMapping>.Equals(QuestionInterviewQuestionMapping other)
        {
            if (EntityIdentifier != default(Guid))
                return EntityIdentifier == other.EntityIdentifier;
            return false;
        }

        #endregion Change Tracking
    }
}