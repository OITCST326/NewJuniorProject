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
    public partial class OpenJob : ModelBase<OpenJob>, IEquatable<OpenJob>, ITrackable
    {
        [DataMember]
        public int openJobsId
        {
            get { return _openJobsId; }
            set
            {
                if (Equals(value, _openJobsId)) return;
                _openJobsId = value;
                NotifyPropertyChanged(m => m.openJobsId);
            }
        }

        private int _openJobsId;

        [DataMember]
        public int jobId
        {
            get { return _jobId; }
            set
            {
                if (Equals(value, _jobId)) return;
                _jobId = value;
                NotifyPropertyChanged(m => m.jobId);
            }
        }

        private int _jobId;

        [DataMember]
        public int storeId
        {
            get { return _storeId; }
            set
            {
                if (Equals(value, _storeId)) return;
                _storeId = value;
                NotifyPropertyChanged(m => m.storeId);
            }
        }

        private int _storeId;

        [DataMember]
        public int regionId
        {
            get { return _regionId; }
            set
            {
                if (Equals(value, _regionId)) return;
                _regionId = value;
                NotifyPropertyChanged(m => m.regionId);
            }
        }

        private int _regionId;

        [DataMember]
        public Nullable<bool> isApproved
        {
            get { return _isApproved; }
            set
            {
                if (Equals(value, _isApproved)) return;
                _isApproved = value;
                NotifyPropertyChanged(m => m.isApproved);
            }
        }

        private Nullable<bool> _isApproved;

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
        public Store Store
        {
            get { return _Store; }
            set
            {
                if (Equals(value, _Store)) return;
                _Store = value;
                StoreChangeTracker = _Store == null ? null
                    : new ChangeTrackingCollection<Store> { _Store };
                NotifyPropertyChanged(m => m.Store);
            }
        }

        private Store _Store;

        private ChangeTrackingCollection<Store> StoreChangeTracker { get; set; }

        [DataMember]
        public Region Region
        {
            get { return _Region; }
            set
            {
                if (Equals(value, _Region)) return;
                _Region = value;
                RegionChangeTracker = _Region == null ? null
                    : new ChangeTrackingCollection<Region> { _Region };
                NotifyPropertyChanged(m => m.Region);
            }
        }

        private Region _Region;

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