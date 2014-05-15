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
    public partial class ApplicantQuestionAnswer : ModelBase<ApplicantQuestionAnswer>, ITrackable
    {
        [DataMember]
        public int answerId
        {
            get { return _answerId; }
            set
            {
                if (value == _answerId) return;
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
                if (value == _applicantId) return;
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
                if (value == _quesitonId) return;
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
                if (value == _answerJsonString) return;
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
                if (value == _Applicant) return;
                _Applicant = value;
                NotifyPropertyChanged(m => m.Applicant);
            }
        }

        private Applicant _Applicant;

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