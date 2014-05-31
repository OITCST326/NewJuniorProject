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
    public partial class OpenJob : ModelBase<OpenJob>, IEquatable<OpenJob>, ITrackable
    {
        [DataMember]
        public int OpenJobsId
        {
            get { return _openJobsId; }
            set
            {
                if (Equals(value, _openJobsId)) return;
                _openJobsId = value;
                NotifyPropertyChanged(m => m.OpenJobsId);
            }
        }

        private int _openJobsId;

        [DataMember]
        public int JobId
        {
            get { return _jobId; }
            set
            {
                if (Equals(value, _jobId)) return;
                _jobId = value;
                NotifyPropertyChanged(m => m.JobId);
            }
        }

        private int _jobId;

        [DataMember]
        public int StoreId
        {
            get { return _storeId; }
            set
            {
                if (Equals(value, _storeId)) return;
                _storeId = value;
                NotifyPropertyChanged(m => m.StoreId);
            }
        }

        private int _storeId;

        [DataMember]
        public int RegionId
        {
            get { return _regionId; }
            set
            {
                if (Equals(value, _regionId)) return;
                _regionId = value;
                NotifyPropertyChanged(m => m.RegionId);
            }
        }

        private int _regionId;

        [DataMember]
        public Nullable<bool> IsApproved
        {
            get { return _IsApproved; }
            set
            {
                if (Equals(value, _IsApproved)) return;
                _IsApproved = value;
                NotifyPropertyChanged(m => m.IsApproved);
            }
        }

        private Nullable<bool> _IsApproved;

        [DataMember]
        public Job Job
        {
            get { return _job; }
            set
            {
                if (Equals(value, _job)) return;
                _job = value;
                JobChangeTracker = _job == null ? null
                    : new ChangeTrackingCollection<Job> { _job };
                NotifyPropertyChanged(m => m.Job);
            }
        }

        private Job _job;

        private ChangeTrackingCollection<Job> JobChangeTracker { get; set; }

        [DataMember]
        public Store Store
        {
            get { return _store; }
            set
            {
                if (Equals(value, _store)) return;
                _store = value;
                StoreChangeTracker = _store == null ? null
                    : new ChangeTrackingCollection<Store> { _store };
                NotifyPropertyChanged(m => m.Store);
            }
        }

        private Store _store;

        private ChangeTrackingCollection<Store> StoreChangeTracker { get; set; }

        [DataMember]
        public Region Region
        {
            get { return _region; }
            set
            {
                if (Equals(value, _region)) return;
                _region = value;
                RegionChangeTracker = _region == null ? null
                    : new ChangeTrackingCollection<Region> { _region };
                NotifyPropertyChanged(m => m.Region);
            }
        }

        private Region _region;

        private ChangeTrackingCollection<Region> RegionChangeTracker { get; set; }

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

        bool IEquatable<OpenJob>.Equals(OpenJob other)
        {
            if (EntityIdentifier != default(Guid))
                return EntityIdentifier == other.EntityIdentifier;
            return false;
        }

        #endregion Change Tracking
    }
}