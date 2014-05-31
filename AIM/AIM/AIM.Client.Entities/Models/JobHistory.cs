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
    public partial class JobHistory : ModelBase<JobHistory>, IEquatable<JobHistory>, ITrackable
    {
        [DataMember]
        public int jobHistoryId
        {
            get { return _jobHistoryId; }
            set
            {
                if (Equals(value, _jobHistoryId)) return;
                _jobHistoryId = value;
                NotifyPropertyChanged(m => m.jobHistoryId);
            }
        }

        private int _jobHistoryId;

        [DataMember]
        public string employerName
        {
            get { return _employerName; }
            set
            {
                if (Equals(value, _employerName)) return;
                _employerName = value;
                NotifyPropertyChanged(m => m.employerName);
            }
        }

        private string _employerName;

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
        public string responsibilities
        {
            get { return _responsibilities; }
            set
            {
                if (Equals(value, _responsibilities)) return;
                _responsibilities = value;
                NotifyPropertyChanged(m => m.responsibilities);
            }
        }

        private string _responsibilities;

        [DataMember]
        public string supervisor
        {
            get { return _supervisor; }
            set
            {
                if (Equals(value, _supervisor)) return;
                _supervisor = value;
                NotifyPropertyChanged(m => m.supervisor);
            }
        }

        private string _supervisor;

        [DataMember]
        public Nullable<decimal> startingSalary
        {
            get { return _startingSalary; }
            set
            {
                if (Equals(value, _startingSalary)) return;
                _startingSalary = value;
                NotifyPropertyChanged(m => m.startingSalary);
            }
        }

        private Nullable<decimal> _startingSalary;

        [DataMember]
        public Nullable<decimal> endingSalary
        {
            get { return _endingSalary; }
            set
            {
                if (Equals(value, _endingSalary)) return;
                _endingSalary = value;
                NotifyPropertyChanged(m => m.endingSalary);
            }
        }

        private Nullable<decimal> _endingSalary;

        [DataMember]
        public string reasonForLeaving
        {
            get { return _reasonForLeaving; }
            set
            {
                if (Equals(value, _reasonForLeaving)) return;
                _reasonForLeaving = value;
                NotifyPropertyChanged(m => m.reasonForLeaving);
            }
        }

        private string _reasonForLeaving;

        [DataMember]
        public Nullable<System.DateTime> dateFrom
        {
            get { return _dateFrom; }
            set
            {
                if (Equals(value, _dateFrom)) return;
                _dateFrom = value;
                NotifyPropertyChanged(m => m.dateFrom);
            }
        }

        private Nullable<System.DateTime> _dateFrom;

        [DataMember]
        public Nullable<System.DateTime> dateTo
        {
            get { return _dateTo; }
            set
            {
                if (Equals(value, _dateTo)) return;
                _dateTo = value;
                NotifyPropertyChanged(m => m.dateTo);
            }
        }

        private Nullable<System.DateTime> _dateTo;

        [DataMember]
        public string street
        {
            get { return _street; }
            set
            {
                if (Equals(value, _street)) return;
                _street = value;
                NotifyPropertyChanged(m => m.street);
            }
        }

        private string _street;

        [DataMember]
        public string street2
        {
            get { return _street2; }
            set
            {
                if (Equals(value, _street2)) return;
                _street2 = value;
                NotifyPropertyChanged(m => m.street2);
            }
        }

        private string _street2;

        [DataMember]
        public string city
        {
            get { return _city; }
            set
            {
                if (Equals(value, _city)) return;
                _city = value;
                NotifyPropertyChanged(m => m.city);
            }
        }

        private string _city;

        [DataMember]
        public Nullable<StateEnum> state
        {
            get { return _state; }
            set
            {
                if (Equals(value, _state)) return;
                _state = value;
                NotifyPropertyChanged(m => m.state);
            }
        }

        private Nullable<StateEnum> _state;

        [DataMember]
        public string zip
        {
            get { return _zip; }
            set
            {
                if (Equals(value, _zip)) return;
                _zip = value;
                NotifyPropertyChanged(m => m.zip);
            }
        }

        private string _zip;

        [DataMember]
        public string phone
        {
            get { return _phone; }
            set
            {
                if (Equals(value, _phone)) return;
                _phone = value;
                NotifyPropertyChanged(m => m.phone);
            }
        }

        private string _phone;

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

        bool IEquatable<JobHistory>.Equals(JobHistory other)
        {
            if (EntityIdentifier != default(Guid))
                return EntityIdentifier == other.EntityIdentifier;
            return false;
        }

        #endregion Change Tracking
    }
}