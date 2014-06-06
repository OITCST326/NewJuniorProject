using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;
using TrackableEntities.Client;

namespace AIM.Application.Client.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class InterviewQuestion : ModelBase<InterviewQuestion>, ITrackable
    {
        public InterviewQuestion()
        {
            this.Jobs = new ChangeTrackingCollection<Job>();
            this.QuestionInterviewQuestionMappings = new ChangeTrackingCollection<QuestionInterviewQuestionMapping>();
        }

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
        public int? questionId
        {
            get { return _questionId; }
            set
            {
                if (value == _questionId) return;
                _questionId = value;
                NotifyPropertyChanged(m => m.questionId);
            }
        }

        private int? _questionId;

        [DataMember]
        public int? jobId
        {
            get { return _jobId; }
            set
            {
                if (value == _jobId) return;
                _jobId = value;
                NotifyPropertyChanged(m => m.jobId);
            }
        }

        private int? _jobId;

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
        public ChangeTrackingCollection<QuestionInterviewQuestionMapping> QuestionInterviewQuestionMappings
        {
            get { return _QuestionInterviewQuestionMappings; }
            set
            {
                if (Equals(value, _QuestionInterviewQuestionMappings)) return;
                _QuestionInterviewQuestionMappings = value;
                NotifyPropertyChanged(m => m.QuestionInterviewQuestionMappings);
            }
        }

        private ChangeTrackingCollection<QuestionInterviewQuestionMapping> _QuestionInterviewQuestionMappings;

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
    }
}