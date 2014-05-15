using System;
using AIM.Service.Client.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;
using TrackableEntities.Client;

namespace AIM.Client.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Employee : ModelBase<Employee>, ITrackable
    {
        public Employee()
        {
            this.Users = new ChangeTrackingCollection<User>();
        }

        [DataMember]
        public int employeeId
        {
            get { return _employeeId; }
            set
            {
                if (value == _employeeId) return;
                _employeeId = value;
                NotifyPropertyChanged(m => m.employeeId);
            }
        }

        private int _employeeId;

        [DataMember]
        public Nullable<PermissionsEnum> permissions
        {
            get { return _permissions; }
            set
            {
                if (value == _permissions) return;
                _permissions = value;
                NotifyPropertyChanged(m => m.permissions);
            }
        }

        private Nullable<PermissionsEnum> _permissions;

        [DataMember]
        public Nullable<int> jobId
        {
            get { return _jobId; }
            set
            {
                if (value == _jobId) return;
                _jobId = value;
                NotifyPropertyChanged(m => m.jobId);
            }
        }

        private Nullable<int> _jobId;

        [DataMember]
        public Job Job
        {
            get { return _Job; }
            set
            {
                if (value == _Job) return;
                _Job = value;
                NotifyPropertyChanged(m => m.Job);
            }
        }

        private Job _Job;

        [DataMember]
        public ChangeTrackingCollection<User> Users
        {
            get { return _Users; }
            set
            {
                if (Equals(value, _Users)) return;
                _Users = value;
                NotifyPropertyChanged(m => m.Users);
            }
        }

        private ChangeTrackingCollection<User> _Users;

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
    }
}