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
    public partial class Store : ModelBase<Store>, ITrackable
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
                if (value == _storeId) return;
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
                if (value == _name) return;
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
                if (value == _regionId) return;
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
                if (value == _street) return;
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
                if (value == _street2) return;
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
                if (value == _city) return;
                _city = value;
                NotifyPropertyChanged(m => m.city);
            }
        }

        private string _city;

        [DataMember]
        public Nullable<StateEnum> state
        {
            get { return _state; }
            set
            {
                if (value == _state) return;
                _state = value;
                NotifyPropertyChanged(m => m.state);
            }
        }

        private Nullable<StateEnum> _state;

        [DataMember]
        public string zip
        {
            get { return _zip; }
            set
            {
                if (value == _zip) return;
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
                if (value == _Region) return;
                _Region = value;
                NotifyPropertyChanged(m => m.Region);
            }
        }

        private Region _Region;

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
    }
}