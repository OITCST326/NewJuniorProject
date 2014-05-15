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
    public partial class Job : ModelBase<Job>, ITrackable
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
                if (value == _jobId) return;
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
                if (value == _position) return;
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
                if (value == _description) return;
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
                if (value == _fullPartTime) return;
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
                if (value == _salaryRange) return;
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
                if (value == _questionnaireId) return;
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
                if (value == _hoursId) return;
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
                if (value == _InterviewQuestionId) return;
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
                if (value == _Hour) return;
                _Hour = value;
                NotifyPropertyChanged(m => m.Hour);
            }
        }

        private Hour _Hour;

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

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
    }
}