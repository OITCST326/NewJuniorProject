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
    public partial class PersonalInfo : ModelBase<PersonalInfo>, IEquatable<PersonalInfo>, ITrackable
    {
        public PersonalInfo()
        {
            this.Users = new ChangeTrackingCollection<User>();
        }

        [DataMember]
        public int PersonalInfoId
        {
            get { return _PersonalInfoId; }
            set
            {
                if (Equals(value, _PersonalInfoId)) return;
                _PersonalInfoId = value;
                NotifyPropertyChanged(m => m.PersonalInfoId);
            }
        }

        private int _PersonalInfoId;

        [DataMember]
        public string alias
        {
            get { return _alias; }
            set
            {
                if (Equals(value, _alias)) return;
                _alias = value;
                NotifyPropertyChanged(m => m.alias);
            }
        }

        private string _alias;

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
        public Nullable<StateEnum> state
        {
            get { return _state; }
            set
            {
                if (Equals(value, _state)) return;
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
                if (Equals(value, _zip)) return;
                _zip = value;
                NotifyPropertyChanged(m => m.zip);
            }
        }

        private string _zip;

        [DataMember]
        public string phone
        {
            get { return _phone; }
            set
            {
                if (Equals(value, _phone)) return;
                _phone = value;
                NotifyPropertyChanged(m => m.phone);
            }
        }

        private string _phone;

        [DataMember]
        public Nullable<int> userId
        {
            get { return _userId; }
            set
            {
                if (Equals(value, _userId)) return;
                _userId = value;
                NotifyPropertyChanged(m => m.userId);
            }
        }

        private Nullable<int> _userId;

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

        bool IEquatable<PersonalInfo>.Equals(PersonalInfo other)
        {
            if (EntityIdentifier != default(Guid))
                return EntityIdentifier == other.EntityIdentifier;
            return false;
        }

        #endregion Change Tracking
    }
}