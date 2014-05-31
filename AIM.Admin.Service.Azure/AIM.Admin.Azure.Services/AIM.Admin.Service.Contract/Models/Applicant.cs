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
    public partial class Applicant : ModelBase<Applicant>, IEquatable<Applicant>, ITrackable
    {
        public Applicant()
        {
            this.ApplicantQuestionAnswers = new ChangeTrackingCollection<ApplicantQuestionAnswer>();
            this.Applications = new ChangeTrackingCollection<Application>();
            this.Educations = new ChangeTrackingCollection<Education>();
            this.JobHistories = new ChangeTrackingCollection<JobHistory>();
            this.Hours = new ChangeTrackingCollection<Hour>();
            this.References = new ChangeTrackingCollection<Reference>();
            this.Users = new ChangeTrackingCollection<User>();
        }

        [DataMember]
        public int ApplicantId
        {
            get { return _applicantId; }
            set
            {
                if (Equals(value, _applicantId)) return;
                _applicantId = value;
                NotifyPropertyChanged(m => m.ApplicantId);
            }
        }

        private int _applicantId;

        [DataMember]
        public Nullable<int> EducationId
        {
            get { return _educationId; }
            set
            {
                if (Equals(value, _educationId)) return;
                _educationId = value;
                NotifyPropertyChanged(m => m.EducationId);
            }
        }

        private Nullable<int> _educationId;

        [DataMember]
        public Nullable<int> JobHistoryId
        {
            get { return _jobHistoryId; }
            set
            {
                if (Equals(value, _jobHistoryId)) return;
                _jobHistoryId = value;
                NotifyPropertyChanged(m => m.JobHistoryId);
            }
        }

        private Nullable<int> _jobHistoryId;

        [DataMember]
        public Nullable<int> ReferenceId
        {
            get { return _referenceId; }
            set
            {
                if (Equals(value, _referenceId)) return;
                _referenceId = value;
                NotifyPropertyChanged(m => m.ReferenceId);
            }
        }

        private Nullable<int> _referenceId;

        [DataMember]
        public Nullable<int> UserId
        {
            get { return _userId; }
            set
            {
                if (Equals(value, _userId)) return;
                _userId = value;
                NotifyPropertyChanged(m => m.UserId);
            }
        }

        private Nullable<int> _userId;

        [DataMember]
        public Nullable<int> ApplicationId
        {
            get { return _applicationId; }
            set
            {
                if (Equals(value, _applicationId)) return;
                _applicationId = value;
                NotifyPropertyChanged(m => m.ApplicationId);
            }
        }

        private Nullable<int> _applicationId;

        [DataMember]
        public Nullable<int> AnswerId
        {
            get { return _answerId; }
            set
            {
                if (Equals(value, _answerId)) return;
                _answerId = value;
                NotifyPropertyChanged(m => m.AnswerId);
            }
        }

        private Nullable<int> _answerId;

        [DataMember]
        public Nullable<int> HoursId
        {
            get { return _hoursId; }
            set
            {
                if (Equals(value, _hoursId)) return;
                _hoursId = value;
                NotifyPropertyChanged(m => m.HoursId);
            }
        }

        private Nullable<int> _hoursId;

        [DataMember]
        public ChangeTrackingCollection<ApplicantQuestionAnswer> ApplicantQuestionAnswers
        {
            get { return _applicantQuestionAnswers; }
            set
            {
                if (Equals(value, _applicantQuestionAnswers)) return;
                _applicantQuestionAnswers = value;
                NotifyPropertyChanged(m => m.ApplicantQuestionAnswers);
            }
        }

        private ChangeTrackingCollection<ApplicantQuestionAnswer> _applicantQuestionAnswers;

        [DataMember]
        public ChangeTrackingCollection<Application> Applications
        {
            get { return _applications; }
            set
            {
                if (Equals(value, _applications)) return;
                _applications = value;
                NotifyPropertyChanged(m => m.Applications);
            }
        }

        private ChangeTrackingCollection<Application> _applications;

        [DataMember]
        public ChangeTrackingCollection<Education> Educations
        {
            get { return _educations; }
            set
            {
                if (Equals(value, _educations)) return;
                _educations = value;
                NotifyPropertyChanged(m => m.Educations);
            }
        }

        private ChangeTrackingCollection<Education> _educations;

        [DataMember]
        public ChangeTrackingCollection<JobHistory> JobHistories
        {
            get { return _jobHistories; }
            set
            {
                if (Equals(value, _jobHistories)) return;
                _jobHistories = value;
                NotifyPropertyChanged(m => m.JobHistories);
            }
        }

        private ChangeTrackingCollection<JobHistory> _jobHistories;

        [DataMember]
        public ChangeTrackingCollection<Hour> Hours
        {
            get { return _hours; }
            set
            {
                if (Equals(value, _hours)) return;
                _hours = value;
                NotifyPropertyChanged(m => m.Hours);
            }
        }

        private ChangeTrackingCollection<Hour> _hours;

        [DataMember]
        public ChangeTrackingCollection<Reference> References
        {
            get { return _references; }
            set
            {
                if (Equals(value, _references)) return;
                _references = value;
                NotifyPropertyChanged(m => m.References);
            }
        }

        private ChangeTrackingCollection<Reference> _references;

        [DataMember]
        public ChangeTrackingCollection<User> Users
        {
            get { return _users; }
            set
            {
                if (Equals(value, _users)) return;
                _users = value;
                NotifyPropertyChanged(m => m.Users);
            }
        }

        private ChangeTrackingCollection<User> _users;

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

        bool IEquatable<Applicant>.Equals(Applicant other)
        {
            if (EntityIdentifier != default(Guid))
                return EntityIdentifier == other.EntityIdentifier;
            return false;
        }

        #endregion Change Tracking
    }
}