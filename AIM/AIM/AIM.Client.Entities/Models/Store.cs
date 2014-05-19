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
    public partial class Store : ModelBase<Store>, IEquatable<Store>, ITrackable
    {
        public Store()
        {
            this.OpenJobs = new ChangeTrackingCollection<OpenJob>();
        }

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
        public string name
        {
            get { return _name; }
            set
            {
                if (Equals(value, _name)) return;
                _name = value;
                NotifyPropertyChanged(m => m.name);
            }
        }

        private string _name;

        [DataMember]
        public Nullable<int> regionId
        {
            get { return _regionId; }
            set
            {
                if (Equals(value, _regionId)) return;
                _regionId = value;
                NotifyPropertyChanged(m => m.regionId);
            }
        }

        private Nullable<int> _regionId;

        [DataMember]
        public string street
        {
            get { return _street; }
            set
            {
                if (Equals(value, _street)) return;
                _street = value;
                NotifyPropertyChanged(m => m.street);
            }
        }

        private string _street;

        [DataMember]
        public string street2
        {
            get { return _street2; }
            set
            {
                if (Equals(value, _street2)) return;
                _street2 = value;
                NotifyPropertyChanged(m => m.street2);
            }
        }

        private string _street2;

        [DataMember]
        public string city
        {
            get { return _city; }
            set
            {
                if (Equals(value, _city)) return;
                _city = value;
                NotifyPropertyChanged(m => m.city);
            }
        }

        private string _city;

        [DataMember]
        public Nullable<int> state
        {
            get { return _state; }
            set
            {
                if (Equals(value, _state)) return;
                _state = value;
                NotifyPropertyChanged(m => m.state);
            }
        }

        private Nullable<int> _state;

        [DataMember]
        public string zip
        {
            get { return _zip; }
            set
            {
                if (Equals(value, _zip)) return;
                _zip = value;
                NotifyPropertyChanged(m => m.zip);
            }
        }

        private string _zip;

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

        bool IEquatable<Store>.Equals(Store other)
        {
            if (EntityIdentifier != default(Guid))
                return EntityIdentifier == other.EntityIdentifier;
            return false;
        }

        #endregion Change Tracking
    }
}