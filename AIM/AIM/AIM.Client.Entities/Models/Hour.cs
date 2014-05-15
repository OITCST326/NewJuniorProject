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
    public partial class Hour : ModelBase<Hour>, ITrackable
    {
        public Hour()
        {
            this.Jobs = new ChangeTrackingCollection<Job>();
        }

        [DataMember]
        public int hoursId
        {
            get { return _hoursId; }
            set
            {
                if (value == _hoursId) return;
                _hoursId = value;
                NotifyPropertyChanged(m => m.hoursId);
            }
        }

        private int _hoursId;

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
        public Nullable<TimeSpan> monOpen
        {
            get { return _monOpen; }
            set
            {
                if (value == _monOpen) return;
                _monOpen = value;
                NotifyPropertyChanged(m => m.monOpen);
            }
        }

        private Nullable<TimeSpan> _monOpen;

        [DataMember]
        public Nullable<TimeSpan> monClose
        {
            get { return _monClose; }
            set
            {
                if (value == _monClose) return;
                _monClose = value;
                NotifyPropertyChanged(m => m.monClose);
            }
        }

        private Nullable<TimeSpan> _monClose;

        [DataMember]
        public Nullable<TimeSpan> tueOpen
        {
            get { return _tueOpen; }
            set
            {
                if (value == _tueOpen) return;
                _tueOpen = value;
                NotifyPropertyChanged(m => m.tueOpen);
            }
        }

        private Nullable<TimeSpan> _tueOpen;

        [DataMember]
        public Nullable<TimeSpan> tueClose
        {
            get { return _tueClose; }
            set
            {
                if (value == _tueClose) return;
                _tueClose = value;
                NotifyPropertyChanged(m => m.tueClose);
            }
        }

        private Nullable<TimeSpan> _tueClose;

        [DataMember]
        public Nullable<TimeSpan> wedOpen
        {
            get { return _wedOpen; }
            set
            {
                if (value == _wedOpen) return;
                _wedOpen = value;
                NotifyPropertyChanged(m => m.wedOpen);
            }
        }

        private Nullable<TimeSpan> _wedOpen;

        [DataMember]
        public Nullable<TimeSpan> wedClose
        {
            get { return _wedClose; }
            set
            {
                if (value == _wedClose) return;
                _wedClose = value;
                NotifyPropertyChanged(m => m.wedClose);
            }
        }

        private Nullable<TimeSpan> _wedClose;

        [DataMember]
        public Nullable<TimeSpan> thursOpen
        {
            get { return _thursOpen; }
            set
            {
                if (value == _thursOpen) return;
                _thursOpen = value;
                NotifyPropertyChanged(m => m.thursOpen);
            }
        }

        private Nullable<TimeSpan> _thursOpen;

        [DataMember]
        public Nullable<TimeSpan> thursClose
        {
            get { return _thursClose; }
            set
            {
                if (value == _thursClose) return;
                _thursClose = value;
                NotifyPropertyChanged(m => m.thursClose);
            }
        }

        private Nullable<TimeSpan> _thursClose;

        [DataMember]
        public Nullable<TimeSpan> friOpen
        {
            get { return _friOpen; }
            set
            {
                if (value == _friOpen) return;
                _friOpen = value;
                NotifyPropertyChanged(m => m.friOpen);
            }
        }

        private Nullable<TimeSpan> _friOpen;

        [DataMember]
        public Nullable<TimeSpan> friClose
        {
            get { return _friClose; }
            set
            {
                if (value == _friClose) return;
                _friClose = value;
                NotifyPropertyChanged(m => m.friClose);
            }
        }

        private Nullable<TimeSpan> _friClose;

        [DataMember]
        public Nullable<TimeSpan> satOpen
        {
            get { return _satOpen; }
            set
            {
                if (value == _satOpen) return;
                _satOpen = value;
                NotifyPropertyChanged(m => m.satOpen);
            }
        }

        private Nullable<TimeSpan> _satOpen;

        [DataMember]
        public Nullable<TimeSpan> satClose
        {
            get { return _satClose; }
            set
            {
                if (value == _satClose) return;
                _satClose = value;
                NotifyPropertyChanged(m => m.satClose);
            }
        }

        private Nullable<TimeSpan> _satClose;

        [DataMember]
        public Nullable<TimeSpan> sunOpen
        {
            get { return _sunOpen; }
            set
            {
                if (value == _sunOpen) return;
                _sunOpen = value;
                NotifyPropertyChanged(m => m.sunOpen);
            }
        }

        private Nullable<TimeSpan> _sunOpen;

        [DataMember]
        public Nullable<TimeSpan> sunClose
        {
            get { return _sunClose; }
            set
            {
                if (value == _sunClose) return;
                _sunClose = value;
                NotifyPropertyChanged(m => m.sunClose);
            }
        }

        private Nullable<TimeSpan> _sunClose;

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
        public ChangeTrackingCollection<Job> Jobs
        {
            get { return _Jobs; }
            set
            {
                if (Equals(value, _Jobs)) return;
                _Jobs = value;
                NotifyPropertyChanged(m => m.Jobs);
            }
        }

        private ChangeTrackingCollection<Job> _Jobs;

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
    }
}