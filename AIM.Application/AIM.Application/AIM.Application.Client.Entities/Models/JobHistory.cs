using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;
using TrackableEntities.Client;

namespace AIM.Application.Client.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class JobHistory : ModelBase<JobHistory>, ITrackable
    {
        [DataMember]
        public int jobHistoryId
        {
            get { return _jobHistoryId; }
            set
            {
                if (value == _jobHistoryId) return;
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
                if (value == _employerName) return;
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
                if (value == _position) return;
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
                if (value == _responsibilities) return;
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
                if (value == _supervisor) return;
                _supervisor = value;
                NotifyPropertyChanged(m => m.supervisor);
            }
        }

        private string _supervisor;

        [DataMember]
        public decimal? startingSalary
        {
            get { return _startingSalary; }
            set
            {
                if (value == _startingSalary) return;
                _startingSalary = value;
                NotifyPropertyChanged(m => m.startingSalary);
            }
        }

        private decimal? _startingSalary;

        [DataMember]
        public decimal? endingSalary
        {
            get { return _endingSalary; }
            set
            {
                if (value == _endingSalary) return;
                _endingSalary = value;
                NotifyPropertyChanged(m => m.endingSalary);
            }
        }

        private decimal? _endingSalary;

        [DataMember]
        public string reasonForLeaving
        {
            get { return _reasonForLeaving; }
            set
            {
                if (value == _reasonForLeaving) return;
                _reasonForLeaving = value;
                NotifyPropertyChanged(m => m.reasonForLeaving);
            }
        }

        private string _reasonForLeaving;

        [DataMember]
        public DateTime? dateFrom
        {
            get { return _dateFrom; }
            set
            {
                if (value == _dateFrom) return;
                _dateFrom = value;
                NotifyPropertyChanged(m => m.dateFrom);
            }
        }

        private DateTime? _dateFrom;

        [DataMember]
        public DateTime? dateTo
        {
            get { return _dateTo; }
            set
            {
                if (value == _dateTo) return;
                _dateTo = value;
                NotifyPropertyChanged(m => m.dateTo);
            }
        }

        private DateTime? _dateTo;

        [DataMember]
        public string street
        {
            get { return _street; }
            set
            {
                if (value == _street) return;
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
                if (value == _street2) return;
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
                if (value == _city) return;
                _city = value;
                NotifyPropertyChanged(m => m.city);
            }
        }

        private string _city;

        [DataMember]
        public StateEnum? state
        {
            get { return _state; }
            set
            {
                if (value == _state) return;
                _state = value;
                NotifyPropertyChanged(m => m.state);
            }
        }

        private StateEnum? _state;

        [DataMember]
        public string zip
        {
            get { return _zip; }
            set
            {
                if (value == _zip) return;
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
                if (value == _phone) return;
                _phone = value;
                NotifyPropertyChanged(m => m.phone);
            }
        }

        private string _phone;

        [DataMember]
        public int? applicantId
        {
            get { return _applicantId; }
            set
            {
                if (value == _applicantId) return;
                _applicantId = value;
                NotifyPropertyChanged(m => m.applicantId);
            }
        }

        private int? _applicantId;

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
        public ICollection<string> ModifiedProperties { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
    }
}