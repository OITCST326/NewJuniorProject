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
    public partial class Education : ModelBase<Education>, IEquatable<Education>, ITrackable
    {
        [DataMember]
        public int educationId
        {
            get { return _educationId; }
            set
            {
                if (Equals(value, _educationId)) return;
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
                if (Equals(value, _schoolName)) return;
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
                if (Equals(value, _degree)) return;
                _degree = value;
                NotifyPropertyChanged(m => m.degree);
            }
        }

        private string _degree;

        [DataMember]
        public Nullable<System.DateTime> graduated
        {
            get { return _graduated; }
            set
            {
                if (Equals(value, _graduated)) return;
                _graduated = value;
                NotifyPropertyChanged(m => m.graduated);
            }
        }

        private Nullable<System.DateTime> _graduated;

        [DataMember]
        public string yearsAttended
        {
            get { return _yearsAttended; }
            set
            {
                if (Equals(value, _yearsAttended)) return;
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

        bool IEquatable<Education>.Equals(Education other)
        {
            if (EntityIdentifier != default(Guid))
                return EntityIdentifier == other.EntityIdentifier;
            return false;
        }

        #endregion Change Tracking
    }
}