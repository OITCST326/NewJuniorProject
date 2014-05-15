using AIM.Service.Client.Models;
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
    public partial class Application : ModelBase<Application>, ITrackable
    {
        [DataMember]
        public int applicationId
        {
            get { return _applicationId; }
            set
            {
                if (value == _applicationId) return;
                _applicationId = value;
                NotifyPropertyChanged(m => m.applicationId);
            }
        }

        private int _applicationId;

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
        public Nullable<DateTime> dateCreated
        {
            get { return _dateCreated; }
            set
            {
                if (value == _dateCreated) return;
                _dateCreated = value;
                NotifyPropertyChanged(m => m.dateCreated);
            }
        }

        private Nullable<DateTime> _dateCreated;

        [DataMember]
        public string preEmploymentStatement
        {
            get { return _preEmploymentStatement; }
            set
            {
                if (value == _preEmploymentStatement) return;
                _preEmploymentStatement = value;
                NotifyPropertyChanged(m => m.preEmploymentStatement);
            }
        }

        private string _preEmploymentStatement;

        [DataMember]
        public Nullable<int> jobId
        {
            get { return _jobId; }
            set
            {
                if (value == _jobId) return;
                _jobId = value;
                NotifyPropertyChanged(m => m.jobId);
            }
        }

        private Nullable<int> _jobId;

        [DataMember]
        public Nullable<StatusEnum> status
        {
            get { return _status; }
            set
            {
                if (value == _status) return;
                _status = value;
                NotifyPropertyChanged(m => m.status);
            }
        }

        private Nullable<StatusEnum> _status;

        [DataMember]
        public string salaryExpectation
        {
            get { return _salaryExpectation; }
            set
            {
                if (value == _salaryExpectation) return;
                _salaryExpectation = value;
                NotifyPropertyChanged(m => m.salaryExpectation);
            }
        }

        private string _salaryExpectation;

        [DataMember]
        public bool isFullTime
        {
            get { return _isFullTime; }
            set
            {
                if (value == _isFullTime) return;
                _isFullTime = value;
                NotifyPropertyChanged(m => m.isFullTime);
            }
        }

        private bool _isFullTime;

        [DataMember]
        public bool isDays
        {
            get { return _isDays; }
            set
            {
                if (value == _isDays) return;
                _isDays = value;
                NotifyPropertyChanged(m => m.isDays);
            }
        }

        private bool _isDays;

        [DataMember]
        public bool isEvenings
        {
            get { return _isEvenings; }
            set
            {
                if (value == _isEvenings) return;
                _isEvenings = value;
                NotifyPropertyChanged(m => m.isEvenings);
            }
        }

        private bool _isEvenings;

        [DataMember]
        public bool isWeekends
        {
            get { return _isWeekends; }
            set
            {
                if (value == _isWeekends) return;
                _isWeekends = value;
                NotifyPropertyChanged(m => m.isWeekends);
            }
        }

        private bool _isWeekends;

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
        public Job Job
        {
            get { return _Job; }
            set
            {
                if (value == _Job) return;
                _Job = value;
                NotifyPropertyChanged(m => m.Job);
            }
        }

        private Job _Job;

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
    }
}