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
    public partial class QuestionQuestionnaire : ModelBase<QuestionQuestionnaire>, ITrackable
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
        public Nullable<int> numberOfQuestions
        {
            get { return _numberOfQuestions; }
            set
            {
                if (value == _numberOfQuestions) return;
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
                if (value == _Questionnaire) return;
                _Questionnaire = value;
                NotifyPropertyChanged(m => m.Questionnaire);
            }
        }

        private Questionnaire _Questionnaire;

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