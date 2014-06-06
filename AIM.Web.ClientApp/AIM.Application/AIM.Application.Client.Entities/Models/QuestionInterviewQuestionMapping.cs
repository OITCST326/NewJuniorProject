using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;
using TrackableEntities.Client;

namespace AIM.Application.Client.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class QuestionInterviewQuestionMapping : ModelBase<QuestionInterviewQuestionMapping>, ITrackable
    {
        [DataMember]
        public int questionId
        {
            get { return _questionId; }
            set
            {
                if (value == _questionId) return;
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
                if (value == _interviewQuestionsId) return;
                _interviewQuestionsId = value;
                NotifyPropertyChanged(m => m.interviewQuestionsId);
            }
        }

        private int _interviewQuestionsId;

        [DataMember]
        public int? numberOfQuestions
        {
            get { return _numberOfQuestions; }
            set
            {
                if (value == _numberOfQuestions) return;
                _numberOfQuestions = value;
                NotifyPropertyChanged(m => m.numberOfQuestions);
            }
        }

        private int? _numberOfQuestions;

        [DataMember]
        public InterviewQuestion InterviewQuestion
        {
            get { return _InterviewQuestion; }
            set
            {
                if (value == _InterviewQuestion) return;
                _InterviewQuestion = value;
                NotifyPropertyChanged(m => m.InterviewQuestion);
            }
        }

        private InterviewQuestion _InterviewQuestion;

        [DataMember]
        public Question Question
        {
            get { return _Question; }
            set
            {
                if (value == _Question) return;
                _Question = value;
                NotifyPropertyChanged(m => m.Question);
            }
        }

        private Question _Question;

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
    }
}