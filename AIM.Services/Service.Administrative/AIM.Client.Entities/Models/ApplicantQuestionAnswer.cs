using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using TrackableEntities;
using TrackableEntities.Client;

namespace AIM.Client.Entities.Models
{
    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true, Namespace = "http://schemas.datacontract.org/2004/07/TrackableEntities.Models")]
    public partial class ApplicantQuestionAnswer : ModelBase<ApplicantQuestionAnswer>, IEquatable<ApplicantQuestionAnswer>, ITrackable
    {
		[DataMember]
		public int AnswerId
		{ 
			get { return _AnswerId; }
			set
			{
				if (Equals(value, _AnswerId)) return;
				_AnswerId = value;
				NotifyPropertyChanged(m => m.AnswerId);
			}
		}
		private int _AnswerId;

		[DataMember]
		public Nullable<int> ApplicantId
		{ 
			get { return _ApplicantId; }
			set
			{
				if (Equals(value, _ApplicantId)) return;
				_ApplicantId = value;
				NotifyPropertyChanged(m => m.ApplicantId);
			}
		}
		private Nullable<int> _ApplicantId;

		[DataMember]
		public Nullable<int> QuesitonId
		{ 
			get { return _QuesitonId; }
			set
			{
				if (Equals(value, _QuesitonId)) return;
				_QuesitonId = value;
				NotifyPropertyChanged(m => m.QuesitonId);
			}
		}
		private Nullable<int> _QuesitonId;

		[DataMember]
		public string AnswerJsonString
		{ 
			get { return _AnswerJsonString; }
			set
			{
				if (Equals(value, _AnswerJsonString)) return;
				_AnswerJsonString = value;
				NotifyPropertyChanged(m => m.AnswerJsonString);
			}
		}
		private string _AnswerJsonString;

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
		public Question Question
		{
			get { return _Question; }
			set
			{
				if (Equals(value, _Question)) return;
				_Question = value;
				QuestionChangeTracker = _Question == null ? null
					: new ChangeTrackingCollection<Question> { _Question };
				NotifyPropertyChanged(m => m.Question);
			}
		}
		private Question _Question;
		private ChangeTrackingCollection<Question> QuestionChangeTracker { get; set; }

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

		bool IEquatable<ApplicantQuestionAnswer>.Equals(ApplicantQuestionAnswer other)
		{
			if (EntityIdentifier != default(Guid))
				return EntityIdentifier == other.EntityIdentifier;
			return false;
		}
        #endregion
	}
}
