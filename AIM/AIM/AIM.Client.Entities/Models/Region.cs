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
    public partial class Region : ModelBase<Region>, IEquatable<Region>, ITrackable
    {
        public Region()
        {
            this.OpenJobs = new ChangeTrackingCollection<OpenJob>();
            this.Stores = new ChangeTrackingCollection<Store>();
        }

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
        public string regionName
        {
            get { return _regionName; }
            set
            {
                if (Equals(value, _regionName)) return;
                _regionName = value;
                NotifyPropertyChanged(m => m.regionName);
            }
        }

        private string _regionName;

        [DataMember]
        public ChangeTrackingCollection<OpenJob> OpenJobs
        {
            get { return _OpenJobs; }
            set
            {
                if (Equals(value, _OpenJobs)) return;
                _OpenJobs = value;
                NotifyPropertyChanged(m => m.OpenJobs);
            }
        }

        private ChangeTrackingCollection<OpenJob> _OpenJobs;

        [DataMember]
        public ChangeTrackingCollection<Store> Stores
        {
            get { return _Stores; }
            set
            {
                if (Equals(value, _Stores)) return;
                _Stores = value;
                NotifyPropertyChanged(m => m.Stores);
            }
        }

        private ChangeTrackingCollection<Store> _Stores;

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

        bool IEquatable<Region>.Equals(Region other)
        {
            if (EntityIdentifier != default(Guid))
                return EntityIdentifier == other.EntityIdentifier;
            return false;
        }

        #endregion Change Tracking
    }
}