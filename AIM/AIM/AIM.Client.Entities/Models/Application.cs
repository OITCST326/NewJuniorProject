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
    public partial class Application : ModelBase<Application>, IEquatable<Application>, ITrackable
    {
        [DataMember]
        public int applicationId
        {
            get { return _applicationId; }
            set
            {
                if (Equals(value, _applicationId)) return;
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
                if (Equals(value, _applicantId)) return;
                _applicantId = value;
                NotifyPropertyChanged(m => m.applicantId);
            }
        }

        private Nullable<int> _applicantId;

        [DataMember]
        public Nullable<System.DateTime> dateCreated
        {
            get { return _dateCreated; }
            set
            {
                if (Equals(value, _dateCreated)) return;
                _dateCreated = value;
                NotifyPropertyChanged(m => m.dateCreated);
            }
        }

        private Nullable<System.DateTime> _dateCreated;

        [DataMember]
        public string preEmploymentStatement
        {
            get { return _preEmploymentStatement; }
            set
            {
                if (Equals(value, _preEmploymentStatement)) return;
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
                if (Equals(value, _jobId)) return;
                _jobId = value;
                NotifyPropertyChanged(m => m.jobId);
            }
        }

        private Nullable<int> _jobId;

        [DataMember]
        public Nullable<int> status
        {
            get { return _status; }
            set
            {
                if (Equals(value, _status)) return;
                _status = value;
                NotifyPropertyChanged(m => m.status);
            }
        }

        private Nullable<int> _status;

        [DataMember]
        public string salaryExpectation
        {
            get { return _salaryExpectation; }
            set
            {
                if (Equals(value, _salaryExpectation)) return;
                _salaryExpectation = value;
                NotifyPropertyChanged(m => m.salaryExpectation);
            }
        }

        private string _salaryExpectation;

        [DataMember]
        public Nullable<bool> isFullTime
        {
            get { return _isFullTime; }
            set
            {
                if (Equals(value, _isFullTime)) return;
                _isFullTime = value;
                NotifyPropertyChanged(m => m.isFullTime);
            }
        }

        private Nullable<bool> _isFullTime;

        [DataMember]
        public Nullable<bool> isDays
        {
            get { return _isDays; }
            set
            {
                if (Equals(value, _isDays)) return;
                _isDays = value;
                NotifyPropertyChanged(m => m.isDays);
            }
        }

        private Nullable<bool> _isDays;

        [DataMember]
        public Nullable<bool> isEvenings
        {
            get { return _isEvenings; }
            set
            {
                if (Equals(value, _isEvenings)) return;
                _isEvenings = value;
                NotifyPropertyChanged(m => m.isEvenings);
            }
        }

        private Nullable<bool> _isEvenings;

        [DataMember]
        public Nullable<bool> isWeekends
        {
            get { return _isWeekends; }
            set
            {
                if (Equals(value, _isWeekends)) return;
                _isWeekends = value;
                NotifyPropertyChanged(m => m.isWeekends);
            }
        }

        private Nullable<bool> _isWeekends;

        [DataMember]
        public Applicant Applicant
        {
            get { return _Applicant; }
            set
            {
                if (Equals(value, _Applicant)) return;
                _Applicant = value;
                ApplicantChangeTracker = _Applicant == null ? null
                    : new ChangeTrackingCollection<Applicant> { _Applicant };
                NotifyPropertyChanged(m => m.Applicant);
            }
        }

        private Applicant _Applicant;

        private ChangeTrackingCollection<Applicant> ApplicantChangeTracker { get; set; }

        [DataMember]
        public Job Job
        {
            get { return _Job; }
            set
            {
                if (Equals(value, _Job)) return;
                _Job = value;
                JobChangeTracker = _Job == null ? null
                    : new ChangeTrackingCollection<Job> { _Job };
                NotifyPropertyChanged(m => m.Job);
            }
        }

        private Job _Job;

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