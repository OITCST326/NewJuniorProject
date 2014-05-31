using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TrackableEntities;
using TrackableEntities.Client;

namespace AIM.Application.Client.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class Applicant : ModelBase<Applicant>, ITrackable
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
        public int applicantId
        {
            get { return _applicantId; }
            set
            {
                if (value == _applicantId) return;
                _applicantId = value;
                NotifyPropertyChanged(m => m.applicantId);
            }
        }

        private int _applicantId;

        [DataMember]
        public int? educationId
        {
            get { return _educationId; }
            set
            {
                if (value == _educationId) return;
                _educationId = value;
                NotifyPropertyChanged(m => m.educationId);
            }
        }

        private int? _educationId;

        [DataMember]
        public int? jobHistoryId
        {
            get { return _jobHistoryId; }
            set
            {
                if (value == _jobHistoryId) return;
                _jobHistoryId = value;
                NotifyPropertyChanged(m => m.jobHistoryId);
            }
        }

        private int? _jobHistoryId;

        [DataMember]
        public int? referenceId
        {
            get { return _referenceId; }
            set
            {
                if (value == _referenceId) return;
                _referenceId = value;
                NotifyPropertyChanged(m => m.referenceId);
            }
        }

        private int? _referenceId;

        [DataMember]
        public int? userId
        {
            get { return _userId; }
            set
            {
                if (value == _userId) return;
                _userId = value;
                NotifyPropertyChanged(m => m.userId);
            }
        }

        private int? _userId;

        [DataMember]
        public int? applicationId
        {
            get { return _applicationId; }
            set
            {
                if (value == _applicationId) return;
                _applicationId = value;
                NotifyPropertyChanged(m => m.applicationId);
            }
        }

        private int? _applicationId;

        [DataMember]
        public int? answerId
        {
            get { return _answerId; }
            set
            {
                if (value == _answerId) return;
                _answerId = value;
                NotifyPropertyChanged(m => m.answerId);
            }
        }

        private int? _answerId;

        [DataMember]
        public int? hoursId
        {
            get { return _hoursId; }
            set
            {
                if (value == _hoursId) return;
                _hoursId = value;
                NotifyPropertyChanged(m => m.hoursId);
            }
        }

        private int? _hoursId;

        [DataMember]
        public ChangeTrackingCollection<ApplicantQuestionAnswer> ApplicantQuestionAnswers
        {
            get { return _ApplicantQuestionAnswers; }
            set
            {
                if (Equals(value, _ApplicantQuestionAnswers)) return;
                _ApplicantQuestionAnswers = value;
                NotifyPropertyChanged(m => m.ApplicantQuestionAnswers);
            }
        }

        private ChangeTrackingCollection<ApplicantQuestionAnswer> _ApplicantQuestionAnswers;

        [DataMember]
        public ChangeTrackingCollection<Application> Applications
        {
            get { return _Applications; }
            set
            {
                if (Equals(value, _Applications)) return;
                _Applications = value;
                NotifyPropertyChanged(m => m.Applications);
            }
        }

        private ChangeTrackingCollection<Application> _Applications;

        [DataMember]
        public ChangeTrackingCollection<Education> Educations
        {
            get { return _Educations; }
            set
            {
                if (Equals(value, _Educations)) return;
                _Educations = value;
                NotifyPropertyChanged(m => m.Educations);
            }
        }

        private ChangeTrackingCollection<Education> _Educations;

        [DataMember]
        public ChangeTrackingCollection<JobHistory> JobHistories
        {
            get { return _JobHistories; }
            set
            {
                if (Equals(value, _JobHistories)) return;
                _JobHistories = value;
                NotifyPropertyChanged(m => m.JobHistories);
            }
        }

        private ChangeTrackingCollection<JobHistory> _JobHistories;

        [DataMember]
        public ChangeTrackingCollection<Hour> Hours
        {
            get { return _Hours; }
            set
            {
                if (Equals(value, _Hours)) return;
                _Hours = value;
                NotifyPropertyChanged(m => m.Hours);
            }
        }

        private ChangeTrackingCollection<Hour> _Hours;

        [DataMember]
        public ChangeTrackingCollection<Reference> References
        {
            get { return _References; }
            set
            {
                if (Equals(value, _References)) return;
                _References = value;
                NotifyPropertyChanged(m => m.References);
            }
        }

        private ChangeTrackingCollection<Reference> _References;

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

        [DataMember]
        public ICollection<string> ModifiedProperties { get; set; }

        [DataMember]
        public TrackingState TrackingState { get; set; }
    }
}