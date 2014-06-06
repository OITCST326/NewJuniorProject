using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;
using TrackableEntities.Client;

namespace AIM.Application.Client.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Question : ModelBase<Question>, ITrackable
    {
        public Question()
        {
            this.ApplicantQuestionAnswers = new ChangeTrackingCollection<ApplicantQuestionAnswer>();
            this.QuestionInterviewQuestionMappings = new ChangeTrackingCollection<QuestionInterviewQuestionMapping>();
            this.QuestionQuestionnaires = new ChangeTrackingCollection<QuestionQuestionnaire>();
        }

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
        public string qJsonProperties
        {
            get { return _qJsonProperties; }
            set
            {
                if (value == _qJsonProperties) return;
                _qJsonProperties = value;
                NotifyPropertyChanged(m => m.qJsonProperties);
            }
        }

        private string _qJsonProperties;

        [DataMember]
        public int? questionnaireId
        {
            get { return _questionnaireId; }
            set
            {
                if (value == _questionnaireId) return;
                _questionnaireId = value;
                NotifyPropertyChanged(m => m.questionnaireId);
            }
        }

        private int? _questionnaireId;

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
        public ChangeTrackingCollection<ApplicantQuestionAnswer> ApplicantQuestionAnswers
        {
            get { return _ApplicantQuestionAnswers; }
            set
            {
                if (Equals(value, _ApplicantQuestionAnswers)) return;
                _ApplicantQuestionAnswers = value;
                NotifyPropertyChanged(m => m.ApplicantQuestionAnswers);
            }
        }

        private ChangeTrackingCollection<ApplicantQuestionAnswer> _ApplicantQuestionAnswers;

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

        [DataMember]
        public int qJsonId { get; set; }

        [DataMember]
        public TypeEnum qJsonType { get; set; }

        [DataMember]
        public string qJsonText { get; set; }

        [DataMember]
        public IList<string> qJsonOptionList { get; set; }

        [DataMember]
        public IList<string> qJsonAnswerList { get; set; }
    }
}