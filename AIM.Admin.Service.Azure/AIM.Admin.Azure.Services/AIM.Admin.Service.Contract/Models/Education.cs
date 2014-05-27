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
    public partial class Education : ModelBase<Education>, IEquatable<Education>, ITrackable
    {
        [DataMember]
        public int EducationId
        {
            get { return _educationId; }
            set
            {
                if (Equals(value, _educationId)) return;
                _educationId = value;
                NotifyPropertyChanged(m => m.EducationId);
            }
        }

        private int _educationId;

        [DataMember]
        public string SchoolName
        {
            get { return _schoolName; }
            set
            {
                if (Equals(value, _schoolName)) return;
                _schoolName = value;
                NotifyPropertyChanged(m => m.SchoolName);
            }
        }

        private string _schoolName;

        [DataMember]
        public string Degree
        {
            get { return _degree; }
            set
            {
                if (Equals(value, _degree)) return;
                _degree = value;
                NotifyPropertyChanged(m => m.Degree);
            }
        }

        private string _degree;

        [DataMember]
        public Nullable<System.DateTime> Graduated
        {
            get { return _graduated; }
            set
            {
                if (Equals(value, _graduated)) return;
                _graduated = value;
                NotifyPropertyChanged(m => m.Graduated);
            }
        }

        private Nullable<System.DateTime> _graduated;

        [DataMember]
        public string YearsAttended
        {
            get { return _yearsAttended; }
            set
            {
                if (Equals(value, _yearsAttended)) return;
                _yearsAttended = value;
                NotifyPropertyChanged(m => m.YearsAttended);
            }
        }

        private string _yearsAttended;

        [DataMember]
        public string Street
        {
            get { return _street; }
            set
            {
                if (Equals(value, _street)) return;
                _street = value;
                NotifyPropertyChanged(m => m.Street);
            }
        }

        private string _street;

        [DataMember]
        public string Street2
        {
            get { return _street2; }
            set
            {
                if (Equals(value, _street2)) return;
                _street2 = value;
                NotifyPropertyChanged(m => m.Street2);
            }
        }

        private string _street2;

        [DataMember]
        public string City
        {
            get { return _city; }
            set
            {
                if (Equals(value, _city)) return;
                _city = value;
                NotifyPropertyChanged(m => m.City);
            }
        }

        private string _city;

        [DataMember]
        public Nullable<int> State
        {
            get { return _state; }
            set
            {
                if (Equals(value, _state)) return;
                _state = value;
                NotifyPropertyChanged(m => m.State);
            }
        }

        private Nullable<int> _state;

        [DataMember]
        public string Zip
        {
            get { return _zip; }
            set
            {
                if (Equals(value, _zip)) return;
                _zip = value;
                NotifyPropertyChanged(m => m.Zip);
            }
        }

        private string _zip;

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