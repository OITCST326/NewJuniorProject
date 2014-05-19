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
    public partial class Job : ModelBase<Job>, IEquatable<Job>, ITrackable
    {
        public Job()
        {
            this.Applications = new ChangeTrackingCollection<Application>();
            this.Employees = new ChangeTrackingCollection<Employee>();
            this.OpenJobs = new ChangeTrackingCollection<OpenJob>();
        }

        [DataMember]
        public int jobId
        {
            get { return _jobId; }
            set
            {
                if (Equals(value, _jobId)) return;
                _jobId = value;
                NotifyPropertyChanged(m => m.jobId);
            }
        }

        private int _jobId;

        [DataMember]
        public string position
        {
            get { return _position; }
            set
            {
                if (Equals(value, _position)) return;
                _position = value;
                NotifyPropertyChanged(m => m.position);
            }
        }

        private string _position;

        [DataMember]
        public string description
        {
            get { return _description; }
            set
            {
                if (Equals(value, _description)) return;
                _description = value;
                NotifyPropertyChanged(m => m.description);
            }
        }

        private string _description;

        [DataMember]
        public string fullPartTime
        {
            get { return _fullPartTime; }
            set
            {
                if (Equals(value, _fullPartTime)) return;
                _fullPartTime = value;
                NotifyPropertyChanged(m => m.fullPartTime);
            }
        }

        private string _fullPartTime;

        [DataMember]
        public string salaryRange
        {
            get { return _salaryRange; }
            set
            {
                if (Equals(value, _salaryRange)) return;
                _salaryRange = value;
                NotifyPropertyChanged(m => m.salaryRange);
            }
        }

        private string _salaryRange;

        [DataMember]
        public Nullable<int> questionnaireId
        {
            get { return _questionnaireId; }
            set
            {
                if (Equals(value, _questionnaireId)) return;
                _questionnaireId = value;
                NotifyPropertyChanged(m => m.questionnaireId);
            }
        }

        private Nullable<int> _questionnaireId;

        [DataMember]
        public Nullable<int> hoursId
        {
            get { return _hoursId; }
            set
            {
                if (Equals(value, _hoursId)) return;
                _hoursId = value;
                NotifyPropertyChanged(m => m.hoursId);
            }
        }

        private Nullable<int> _hoursId;

        [DataMember]
        public Nullable<int> InterviewQuestionId
        {
            get { return _InterviewQuestionId; }
            set
            {
                if (Equals(value, _InterviewQuestionId)) return;
                _InterviewQuestionId = value;
                NotifyPropertyChanged(m => m.InterviewQuestionId);
            }
        }

        private Nullable<int> _InterviewQuestionId;

        [DataMember]
        public ChangeTrackingCollection<Application> Applications
        {
            get { return _Applications; }
            set
            {
                if (Equals(value, _Applications)) return;
                _Applications = value;
                NotifyPropertyChanged(m => m.Applications);
            }
        }

        private ChangeTrackingCollection<Application> _Applications;

        [DataMember]
        public ChangeTrackingCollection<Employee> Employees
        {
            get { return _Employees; }
            set
            {
                if (Equals(value, _Employees)) return;
                _Employees = value;
                NotifyPropertyChanged(m => m.Employees);
            }
        }

        private ChangeTrackingCollection<Employee> _Employees;

        [DataMember]
        public Hour Hour
        {
            get { return _Hour; }
            set
            {
                if (Equals(value, _Hour)) return;
                _Hour = value;
                HourChangeTracker = _Hour == null ? null
                    : new ChangeTrackingCollection<Hour> { _Hour };
                NotifyPropertyChanged(m => m.Hour);
            }
        }

        private Hour _Hour;

        private ChangeTrackingCollection<Hour> HourChangeTracker { get; set; }

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
        public ChangeTrackingCollection<OpenJob> OpenJobs
        {
            get { return _OpenJobs; }
            set
            {
                if (Equals(value, _OpenJobs)) return;
                _OpenJobs = value;
                NotifyPropertyChanged(m => m.OpenJobs);
            }
        }

        private ChangeTrackingCollection<OpenJob> _OpenJobs;

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

        bool IEquatable<Job>.Equals(Job other)
        {
            if (EntityIdentifier != default(Guid))
                return EntityIdentifier == other.EntityIdentifier;
            return false;
        }

        #endregion Change Tracking
    }
}