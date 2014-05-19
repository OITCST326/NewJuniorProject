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
    public partial class User : ModelBase<User>, IEquatable<User>, ITrackable
    {
        [DataMember]
        public int userId
        {
            get { return _userId; }
            set
            {
                if (Equals(value, _userId)) return;
                _userId = value;
                NotifyPropertyChanged(m => m.userId);
            }
        }

        private int _userId;

        [DataMember]
        public string firstName
        {
            get { return _firstName; }
            set
            {
                if (Equals(value, _firstName)) return;
                _firstName = value;
                NotifyPropertyChanged(m => m.firstName);
            }
        }

        private string _firstName;

        [DataMember]
        public string middleName
        {
            get { return _middleName; }
            set
            {
                if (Equals(value, _middleName)) return;
                _middleName = value;
                NotifyPropertyChanged(m => m.middleName);
            }
        }

        private string _middleName;

        [DataMember]
        public string lastName
        {
            get { return _lastName; }
            set
            {
                if (Equals(value, _lastName)) return;
                _lastName = value;
                NotifyPropertyChanged(m => m.lastName);
            }
        }

        private string _lastName;

        [DataMember]
        public string email
        {
            get { return _email; }
            set
            {
                if (Equals(value, _email)) return;
                _email = value;
                NotifyPropertyChanged(m => m.email);
            }
        }

        private string _email;

        [DataMember]
        public string socialSecurityNumber
        {
            get { return _socialSecurityNumber; }
            set
            {
                if (Equals(value, _socialSecurityNumber)) return;
                _socialSecurityNumber = value;
                NotifyPropertyChanged(m => m.socialSecurityNumber);
            }
        }

        private string _socialSecurityNumber;

        [DataMember]
        public Nullable<int> PersonalInfoId
        {
            get { return _PersonalInfoId; }
            set
            {
                if (Equals(value, _PersonalInfoId)) return;
                _PersonalInfoId = value;
                NotifyPropertyChanged(m => m.PersonalInfoId);
            }
        }

        private Nullable<int> _PersonalInfoId;

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
        public Nullable<int> applicationId
        {
            get { return _applicationId; }
            set
            {
                if (Equals(value, _applicationId)) return;
                _applicationId = value;
                NotifyPropertyChanged(m => m.applicationId);
            }
        }

        private Nullable<int> _applicationId;

        [DataMember]
        public Nullable<int> employeeId
        {
            get { return _employeeId; }
            set
            {
                if (Equals(value, _employeeId)) return;
                _employeeId = value;
                NotifyPropertyChanged(m => m.employeeId);
            }
        }

        private Nullable<int> _employeeId;

        [DataMember]
        public string userName
        {
            get { return _userName; }
            set
            {
                if (Equals(value, _userName)) return;
                _userName = value;
                NotifyPropertyChanged(m => m.userName);
            }
        }

        private string _userName;

        [DataMember]
        public string password
        {
            get { return _password; }
            set
            {
                if (Equals(value, _password)) return;
                _password = value;
                NotifyPropertyChanged(m => m.password);
            }
        }

        private string _password;

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
        public Employee Employee
        {
            get { return _Employee; }
            set
            {
                if (Equals(value, _Employee)) return;
                _Employee = value;
                EmployeeChangeTracker = _Employee == null ? null
                    : new ChangeTrackingCollection<Employee> { _Employee };
                NotifyPropertyChanged(m => m.Employee);
            }
        }

        private Employee _Employee;

        private ChangeTrackingCollection<Employee> EmployeeChangeTracker { get; set; }

        [DataMember]
        public PersonalInfo PersonalInfo
        {
            get { return _PersonalInfo; }
            set
            {
                if (Equals(value, _PersonalInfo)) return;
                _PersonalInfo = value;
                PersonalInfoChangeTracker = _PersonalInfo == null ? null
                    : new ChangeTrackingCollection<PersonalInfo> { _PersonalInfo };
                NotifyPropertyChanged(m => m.PersonalInfo);
            }
        }

        private PersonalInfo _PersonalInfo;

        private ChangeTrackingCollection<PersonalInfo> PersonalInfoChangeTracker { get; set; }

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

        bool IEquatable<User>.Equals(User other)
        {
            if (EntityIdentifier != default(Guid))
                return EntityIdentifier == other.EntityIdentifier;
            return false;
        }

        #endregion Change Tracking
    }
}