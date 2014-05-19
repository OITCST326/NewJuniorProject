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
    public partial class Employee : ModelBase<Employee>, IEquatable<Employee>, ITrackable
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
                if (Equals(value, _employeeId)) return;
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
                if (Equals(value, _permissions)) return;
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
                if (Equals(value, _jobId)) return;
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
                if (Equals(value, _Job)) return;
                _Job = value;
                JobChangeTracker = _Job == null ? null
                    : new ChangeTrackingCollection<Job> { _Job };
                NotifyPropertyChanged(m => m.Job);
            }
        }

        private Job _Job;

        private ChangeTrackingCollection<Job> JobChangeTracker { get; set; }

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

        bool IEquatable<Employee>.Equals(Employee other)
        {
            if (EntityIdentifier != default(Guid))
                return EntityIdentifier == other.EntityIdentifier;
            return false;
        }

        #endregion Change Tracking
    }
}