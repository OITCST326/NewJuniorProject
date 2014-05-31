using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;
using TrackableEntities.Client;

namespace AIM.Application.Client.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class OpenJob : ModelBase<OpenJob>, ITrackable
    {
        [DataMember]
        public int openJobsId
        {
            get { return _openJobsId; }
            set
            {
                if (value == _openJobsId) return;
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
                if (value == _jobId) return;
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
                if (value == _storeId) return;
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
                if (value == _regionId) return;
                _regionId = value;
                NotifyPropertyChanged(m => m.regionId);
            }
        }

        private int _regionId;

        [DataMember]
        public bool? isApproved
        {
            get { return _isApproved; }
            set
            {
                if (value == _isApproved) return;
                _isApproved = value;
                NotifyPropertyChanged(m => m.isApproved);
            }
        }

        private bool? _isApproved;

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
        public Store Store
        {
            get { return _Store; }
            set
            {
                if (value == _Store) return;
                _Store = value;
                NotifyPropertyChanged(m => m.Store);
            }
        }

        private Store _Store;

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