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
    public partial class User : ModelBase<User>, ITrackable
    {
        [DataMember]
        public int userId
        {
            get { return _userId; }
            set
            {
                if (value == _userId) return;
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
                if (value == _firstName) return;
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
                if (value == _middleName) return;
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
                if (value == _lastName) return;
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
                if (value == _email) return;
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
                if (value == _socialSecurityNumber) return;
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
                if (value == _PersonalInfoId) return;
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
                if (value == _applicantId) return;
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
                if (value == _applicationId) return;
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
                if (value == _employeeId) return;
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
                if (value == _userName) return;
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
                if (value == _password) return;
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
                if (value == _Applicant) return;
                _Applicant = value;
                NotifyPropertyChanged(m => m.Applicant);
            }
        }

        private Applicant _Applicant;

        [DataMember]
        public Employee Employee
        {
            get { return _Employee; }
            set
            {
                if (value == _Employee) return;
                _Employee = value;
                NotifyPropertyChanged(m => m.Employee);
            }
        }

        private Employee _Employee;

        [DataMember]
        public PersonalInfo PersonalInfo
        {
            get { return _PersonalInfo; }
            set
            {
                if (value == _PersonalInfo) return;
                _PersonalInfo = value;
                NotifyPropertyChanged(m => m.PersonalInfo);
            }
        }

        private PersonalInfo _PersonalInfo;

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
    }
}