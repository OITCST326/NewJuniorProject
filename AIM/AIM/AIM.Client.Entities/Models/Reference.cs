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
    public partial class Reference : ModelBase<Reference>, ITrackable
    {
        [DataMember]
        public int referenceId
        {
            get { return _referenceId; }
            set
            {
                if (value == _referenceId) return;
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
                if (value == _refFullName) return;
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
                if (value == _refCompany) return;
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
                if (value == _refTitle) return;
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
                if (value == _refPhone) return;
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
                if (value == _applicantId) return;
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