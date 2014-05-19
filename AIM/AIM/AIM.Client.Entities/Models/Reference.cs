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
    public partial class Reference : ModelBase<Reference>, IEquatable<Reference>, ITrackable
    {
        [DataMember]
        public int referenceId
        {
            get { return _referenceId; }
            set
            {
                if (Equals(value, _referenceId)) return;
                _referenceId = value;
                NotifyPropertyChanged(m => m.referenceId);
            }
        }

        private int _referenceId;

        [DataMember]
        public string refFullName
        {
            get { return _refFullName; }
            set
            {
                if (Equals(value, _refFullName)) return;
                _refFullName = value;
                NotifyPropertyChanged(m => m.refFullName);
            }
        }

        private string _refFullName;

        [DataMember]
        public string refCompany
        {
            get { return _refCompany; }
            set
            {
                if (Equals(value, _refCompany)) return;
                _refCompany = value;
                NotifyPropertyChanged(m => m.refCompany);
            }
        }

        private string _refCompany;

        [DataMember]
        public string refTitle
        {
            get { return _refTitle; }
            set
            {
                if (Equals(value, _refTitle)) return;
                _refTitle = value;
                NotifyPropertyChanged(m => m.refTitle);
            }
        }

        private string _refTitle;

        [DataMember]
        public string refPhone
        {
            get { return _refPhone; }
            set
            {
                if (Equals(value, _refPhone)) return;
                _refPhone = value;
                NotifyPropertyChanged(m => m.refPhone);
            }
        }

        private string _refPhone;

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

        bool IEquatable<Reference>.Equals(Reference other)
        {
            if (EntityIdentifier != default(Guid))
                return EntityIdentifier == other.EntityIdentifier;
            return false;
        }

        #endregion Change Tracking
    }
}