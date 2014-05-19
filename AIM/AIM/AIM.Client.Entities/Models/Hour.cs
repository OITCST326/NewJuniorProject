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
    public partial class Hour : ModelBase<Hour>, IEquatable<Hour>, ITrackable
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
                if (Equals(value, _hoursId)) return;
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
                if (Equals(value, _applicantId)) return;
                _applicantId = value;
                NotifyPropertyChanged(m => m.applicantId);
            }
        }

        private Nullable<int> _applicantId;

        [DataMember]
        public Nullable<System.TimeSpan> monOpen
        {
            get { return _monOpen; }
            set
            {
                if (Equals(value, _monOpen)) return;
                _monOpen = value;
                NotifyPropertyChanged(m => m.monOpen);
            }
        }

        private Nullable<System.TimeSpan> _monOpen;

        [DataMember]
        public Nullable<System.TimeSpan> monClose
        {
            get { return _monClose; }
            set
            {
                if (Equals(value, _monClose)) return;
                _monClose = value;
                NotifyPropertyChanged(m => m.monClose);
            }
        }

        private Nullable<System.TimeSpan> _monClose;

        [DataMember]
        public Nullable<System.TimeSpan> tueOpen
        {
            get { return _tueOpen; }
            set
            {
                if (Equals(value, _tueOpen)) return;
                _tueOpen = value;
                NotifyPropertyChanged(m => m.tueOpen);
            }
        }

        private Nullable<System.TimeSpan> _tueOpen;

        [DataMember]
        public Nullable<System.TimeSpan> tueClose
        {
            get { return _tueClose; }
            set
            {
                if (Equals(value, _tueClose)) return;
                _tueClose = value;
                NotifyPropertyChanged(m => m.tueClose);
            }
        }

        private Nullable<System.TimeSpan> _tueClose;

        [DataMember]
        public Nullable<System.TimeSpan> wedOpen
        {
            get { return _wedOpen; }
            set
            {
                if (Equals(value, _wedOpen)) return;
                _wedOpen = value;
                NotifyPropertyChanged(m => m.wedOpen);
            }
        }

        private Nullable<System.TimeSpan> _wedOpen;

        [DataMember]
        public Nullable<System.TimeSpan> wedClose
        {
            get { return _wedClose; }
            set
            {
                if (Equals(value, _wedClose)) return;
                _wedClose = value;
                NotifyPropertyChanged(m => m.wedClose);
            }
        }

        private Nullable<System.TimeSpan> _wedClose;

        [DataMember]
        public Nullable<System.TimeSpan> thursOpen
        {
            get { return _thursOpen; }
            set
            {
                if (Equals(value, _thursOpen)) return;
                _thursOpen = value;
                NotifyPropertyChanged(m => m.thursOpen);
            }
        }

        private Nullable<System.TimeSpan> _thursOpen;

        [DataMember]
        public Nullable<System.TimeSpan> thursClose
        {
            get { return _thursClose; }
            set
            {
                if (Equals(value, _thursClose)) return;
                _thursClose = value;
                NotifyPropertyChanged(m => m.thursClose);
            }
        }

        private Nullable<System.TimeSpan> _thursClose;

        [DataMember]
        public Nullable<System.TimeSpan> friOpen
        {
            get { return _friOpen; }
            set
            {
                if (Equals(value, _friOpen)) return;
                _friOpen = value;
                NotifyPropertyChanged(m => m.friOpen);
            }
        }

        private Nullable<System.TimeSpan> _friOpen;

        [DataMember]
        public Nullable<System.TimeSpan> friClose
        {
            get { return _friClose; }
            set
            {
                if (Equals(value, _friClose)) return;
                _friClose = value;
                NotifyPropertyChanged(m => m.friClose);
            }
        }

        private Nullable<System.TimeSpan> _friClose;

        [DataMember]
        public Nullable<System.TimeSpan> satOpen
        {
            get { return _satOpen; }
            set
            {
                if (Equals(value, _satOpen)) return;
                _satOpen = value;
                NotifyPropertyChanged(m => m.satOpen);
            }
        }

        private Nullable<System.TimeSpan> _satOpen;

        [DataMember]
        public Nullable<System.TimeSpan> satClose
        {
            get { return _satClose; }
            set
            {
                if (Equals(value, _satClose)) return;
                _satClose = value;
                NotifyPropertyChanged(m => m.satClose);
            }
        }

        private Nullable<System.TimeSpan> _satClose;

        [DataMember]
        public Nullable<System.TimeSpan> sunOpen
        {
            get { return _sunOpen; }
            set
            {
                if (Equals(value, _sunOpen)) return;
                _sunOpen = value;
                NotifyPropertyChanged(m => m.sunOpen);
            }
        }

        private Nullable<System.TimeSpan> _sunOpen;

        [DataMember]
        public Nullable<System.TimeSpan> sunClose
        {
            get { return _sunClose; }
            set
            {
                if (Equals(value, _sunClose)) return;
                _sunClose = value;
                NotifyPropertyChanged(m => m.sunClose);
            }
        }

        private Nullable<System.TimeSpan> _sunClose;

        [DataMember]
        public Applicant Applicant
        {
            get { return _Applicant; }
            set
            {
                if (Equals(value, _Applicant)) return;
                _Applicant = value;
                ApplicantChangeTracker = _Applicant == null ? null
                    : new ChangeTrackingCollection<Applicant> { _Applicant };
                NotifyPropertyChanged(m => m.Applicant);
            }
        }

        private Applicant _Applicant;

        private ChangeTrackingCollection<Applicant> ApplicantChangeTracker { get; set; }

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

        bool IEquatable<Hour>.Equals(Hour other)
        {
            if (EntityIdentifier != default(Guid))
                return EntityIdentifier == other.EntityIdentifier;
            return false;
        }

        #endregion Change Tracking
    }
}