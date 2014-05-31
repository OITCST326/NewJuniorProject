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
    public partial class Education : ModelBase<Education>, ITrackable
    {
        [DataMember]
        public int educationId
        {
            get { return _educationId; }
            set
            {
                if (value == _educationId) return;
                _educationId = value;
                NotifyPropertyChanged(m => m.educationId);
            }
        }

        private int _educationId;

        [DataMember]
        public string schoolName
        {
            get { return _schoolName; }
            set
            {
                if (value == _schoolName) return;
                _schoolName = value;
                NotifyPropertyChanged(m => m.schoolName);
            }
        }

        private string _schoolName;

        [DataMember]
        public string degree
        {
            get { return _degree; }
            set
            {
                if (value == _degree) return;
                _degree = value;
                NotifyPropertyChanged(m => m.degree);
            }
        }

        private string _degree;

        [DataMember]
        public DateTime? graduated
        {
            get { return _graduated; }
            set
            {
                if (value == _graduated) return;
                _graduated = value;
                NotifyPropertyChanged(m => m.graduated);
            }
        }

        private DateTime? _graduated;

        [DataMember]
        public string yearsAttended
        {
            get { return _yearsAttended; }
            set
            {
                if (value == _yearsAttended) return;
                _yearsAttended = value;
                NotifyPropertyChanged(m => m.yearsAttended);
            }
        }

        private string _yearsAttended;

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