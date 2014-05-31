using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;
using TrackableEntities.Client;

namespace AIM.Application.Client.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Region : ModelBase<Region>, ITrackable
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
                if (value == _regionId) return;
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
                if (value == _regionName) return;
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

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
    }
}