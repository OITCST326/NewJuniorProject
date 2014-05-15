using System;
using System.Linq;
using AIM.Service.Client.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;
using TrackableEntities.Client;

namespace AIM.Client.Entities.Models
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
        public Nullable<int> questionnaireId
        {
            get { return _questionnaireId; }
            set
            {
                if (value == _questionnaireId) return;
                _questionnaireId = value;
                NotifyPropertyChanged(m => m.questionnaireId);
            }
        }

        private Nullable<int> _questionnaireId;

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
        public Nullable<int> qJsonId
        {
            get { return _qJsonId; }
            set
            {
                if (value == _qJsonId) return;
                _qJsonId = value;
                NotifyPropertyChanged(m => m.questionnaireId);
            }
        }

        private Nullable<int> _qJsonId;

        [DataMember]
        public Nullable<TypeEnum> qJsonType
        {
            get { return _qJsonType; }
            set
            {
                if (value == _qJsonType) return;
                _qJsonType = value;
                NotifyPropertyChanged(m => m.qJsonType);
            }
        }

        private Nullable<TypeEnum> _qJsonType;

        [DataMember]
        public string qJsonText
        {
            get { return _qJsonText;  }
            set
            {
                if (value == _qJsonText) return;
                _qJsonText = value;
                NotifyPropertyChanged(m => m.qJsonText);
            }
        }

        private string _qJsonText;

        [DataMember]
        public IList<string> qJsonOptionList
        {
            get { return _qJsonOptionList; }
            set
            {
                if (value.Equals(_qJsonOptionList)) return;
                _qJsonOptionList = value;
                NotifyPropertyChanged(m => m.qJsonOptionList);
            }
        }

        private IList<string> _qJsonOptionList = new List<string>();

        [DataMember]
        public IList<string> qJsonAnswerList
        {
            get { return _qJsonAnswerList; }
            set
            {
                if (value.Equals(_qJsonAnswerList)) return;
                _qJsonAnswerList = value;
                NotifyPropertyChanged(m => m.qJsonAnswerList);
            }
        }

        private IList<string> _qJsonAnswerList = new List<string>();
    }
}