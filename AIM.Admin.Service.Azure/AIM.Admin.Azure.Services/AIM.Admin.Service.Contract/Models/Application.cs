using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;
using TrackableEntities.Client;

namespace AIM.Admin.Service.Contract.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Application : ModelBase<Application>, IEquatable<Application>, ITrackable
    {
        [DataMember]
        public int ApplicationId
        {
            get { return _applicationId; }
            set
            {
                if (Equals(value, _applicationId)) return;
                _applicationId = value;
                NotifyPropertyChanged(m => m.ApplicationId);
            }
        }

        private int _applicationId;

        [DataMember]
        public Nullable<int> ApplicantId
        {
            get { return _applicantId; }
            set
            {
                if (Equals(value, _applicantId)) return;
                _applicantId = value;
                NotifyPropertyChanged(m => m.ApplicantId);
            }
        }

        private Nullable<int> _applicantId;

        [DataMember]
        public Nullable<System.DateTime> DateCreated
        {
            get { return _dateCreated; }
            set
            {
                if (Equals(value, _dateCreated)) return;
                _dateCreated = value;
                NotifyPropertyChanged(m => m.DateCreated);
            }
        }

        private Nullable<System.DateTime> _dateCreated;

        [DataMember]
        public string PreEmploymentStatement
        {
            get { return _preEmploymentStatement; }
            set
            {
                if (Equals(value, _preEmploymentStatement)) return;
                _preEmploymentStatement = value;
                NotifyPropertyChanged(m => m.PreEmploymentStatement);
            }
        }

        private string _preEmploymentStatement;

        [DataMember]
        public Nullable<int> JobID
        {
            get { return _jobId; }
            set
            {
                if (Equals(value, _jobId)) return;
                _jobId = value;
                NotifyPropertyChanged(m => m.JobID);
            }
        }

        private Nullable<int> _jobId;

        [DataMember]
        public Nullable<int> Status
        {
            get { return _status; }
            set
            {
                if (Equals(value, _status)) return;
                _status = value;
                NotifyPropertyChanged(m => m.Status);
            }
        }

        private Nullable<int> _status;

        [DataMember]
        public string SalaryExpectation
        {
            get { return _salaryExpectation; }
            set
            {
                if (Equals(value, _salaryExpectation)) return;
                _salaryExpectation = value;
                NotifyPropertyChanged(m => m.SalaryExpectation);
            }
        }

        private string _salaryExpectation;

        [DataMember]
        public Nullable<bool> IsFullTime
        {
            get { return _isFullTime; }
            set
            {
                if (Equals(value, _isFullTime)) return;
                _isFullTime = value;
                NotifyPropertyChanged(m => m.IsFullTime);
            }
        }

        private Nullable<bool> _isFullTime;

        [DataMember]
        public Nullable<bool> IsDays
        {
            get { return _isDays; }
            set
            {
                if (Equals(value, _isDays)) return;
                _isDays = value;
                NotifyPropertyChanged(m => m.IsDays);
            }
        }

        private Nullable<bool> _isDays;

        [DataMember]
        public Nullable<bool> IsEvenings
        {
            get { return _isEvenings; }
            set
            {
                if (Equals(value, _isEvenings)) return;
                _isEvenings = value;
                NotifyPropertyChanged(m => m.IsEvenings);
            }
        }

        private Nullable<bool> _isEvenings;

        [DataMember]
        public Nullable<bool> IsWeekends
        {
            get { return _isWeekends; }
            set
            {
                if (Equals(value, _isWeekends)) return;
                _isWeekends = value;
                NotifyPropertyChanged(m => m.IsWeekends);
            }
        }

        private Nullable<bool> _isWeekends;

        [DataMember]
        public Applicant Applicant
        {
            get { return _applicant; }
            set
            {
                if (Equals(value, _applicant)) return;
                _applicant = value;
                ApplicantChangeTracker = _applicant == null ? null
                    : new ChangeTrackingCollection<Applicant> { _applicant };
                NotifyPropertyChanged(m => m.Applicant);
            }
        }

        private Applicant _applicant;

        private ChangeTrackingCollection<Applicant> ApplicantChangeTracker { get; set; }

        [DataMember]
        public Job Job
        {
            get { return _job; }
            set
            {
                if (Equals(value, _job)) return;
                _job = value;
                JobChangeTracker = _job == null ? null
                    : new ChangeTrackingCollection<Job> { _job };
                NotifyPropertyChanged(m => m.Job);
            }
        }

        private Job _job;

        private ChangeTrackingCollection<Job> JobChangeTracker { get; set; }

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

        bool IEquatable<Application>.Equals(Application other)
        {
            if (EntityIdentifier != default(Guid))
                return EntityIdentifier == other.EntityIdentifier;
            return false;
        }

        #endregion Change Tracking
    }
}