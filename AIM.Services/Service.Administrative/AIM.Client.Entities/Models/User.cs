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
    public partial class User : ModelBase<User>, IEquatable<User>, ITrackable
    {
		[DataMember]
		public int UserId
		{ 
			get { return _UserId; }
			set
			{
				if (Equals(value, _UserId)) return;
				_UserId = value;
				NotifyPropertyChanged(m => m.UserId);
			}
		}
		private int _UserId;

		[DataMember]
		public string FirstName
		{ 
			get { return _FirstName; }
			set
			{
				if (Equals(value, _FirstName)) return;
				_FirstName = value;
				NotifyPropertyChanged(m => m.FirstName);
			}
		}
		private string _FirstName;

		[DataMember]
		public string MiddleName
		{ 
			get { return _MiddleName; }
			set
			{
				if (Equals(value, _MiddleName)) return;
				_MiddleName = value;
				NotifyPropertyChanged(m => m.MiddleName);
			}
		}
		private string _MiddleName;

		[DataMember]
		public string LastName
		{ 
			get { return _LastName; }
			set
			{
				if (Equals(value, _LastName)) return;
				_LastName = value;
				NotifyPropertyChanged(m => m.LastName);
			}
		}
		private string _LastName;

		[DataMember]
		public string Email
		{ 
			get { return _Email; }
			set
			{
				if (Equals(value, _Email)) return;
				_Email = value;
				NotifyPropertyChanged(m => m.Email);
			}
		}
		private string _Email;

		[DataMember]
		public string SocialSecurityNumber
		{ 
			get { return _SocialSecurityNumber; }
			set
			{
				if (Equals(value, _SocialSecurityNumber)) return;
				_SocialSecurityNumber = value;
				NotifyPropertyChanged(m => m.SocialSecurityNumber);
			}
		}
		private string _SocialSecurityNumber;

		[DataMember]
		public Nullable<int> PersonalInfoId
		{ 
			get { return _PersonalInfoId; }
			set
			{
				if (Equals(value, _PersonalInfoId)) return;
				_PersonalInfoId = value;
				NotifyPropertyChanged(m => m.PersonalInfoId);
			}
		}
		private Nullable<int> _PersonalInfoId;

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
		public Nullable<int> ApplicationId
		{ 
			get { return _ApplicationId; }
			set
			{
				if (Equals(value, _ApplicationId)) return;
				_ApplicationId = value;
				NotifyPropertyChanged(m => m.ApplicationId);
			}
		}
		private Nullable<int> _ApplicationId;

		[DataMember]
		public Nullable<int> EmployeeId
		{ 
			get { return _EmployeeId; }
			set
			{
				if (Equals(value, _EmployeeId)) return;
				_EmployeeId = value;
				NotifyPropertyChanged(m => m.EmployeeId);
			}
		}
		private Nullable<int> _EmployeeId;

		[DataMember]
		public string UserName
		{ 
			get { return _UserName; }
			set
			{
				if (Equals(value, _UserName)) return;
				_UserName = value;
				NotifyPropertyChanged(m => m.UserName);
			}
		}
		private string _UserName;

		[DataMember]
		public string Password
		{ 
			get { return _Password; }
			set
			{
				if (Equals(value, _Password)) return;
				_Password = value;
				NotifyPropertyChanged(m => m.Password);
			}
		}
		private string _Password;

		[DataMember]
		public string AspNetUsersId
		{ 
			get { return _AspNetUsersId; }
			set
			{
				if (Equals(value, _AspNetUsersId)) return;
				_AspNetUsersId = value;
				NotifyPropertyChanged(m => m.AspNetUsersId);
			}
		}
		private string _AspNetUsersId;

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
		public AspNetUser AspNetUser
		{
			get { return _AspNetUser; }
			set
			{
				if (Equals(value, _AspNetUser)) return;
				_AspNetUser = value;
				AspNetUserChangeTracker = _AspNetUser == null ? null
					: new ChangeTrackingCollection<AspNetUser> { _AspNetUser };
				NotifyPropertyChanged(m => m.AspNetUser);
			}
		}
		private AspNetUser _AspNetUser;
		private ChangeTrackingCollection<AspNetUser> AspNetUserChangeTracker { get; set; }

		[DataMember]
		public Employee Employee
		{
			get { return _Employee; }
			set
			{
				if (Equals(value, _Employee)) return;
				_Employee = value;
				EmployeeChangeTracker = _Employee == null ? null
					: new ChangeTrackingCollection<Employee> { _Employee };
				NotifyPropertyChanged(m => m.Employee);
			}
		}
		private Employee _Employee;
		private ChangeTrackingCollection<Employee> EmployeeChangeTracker { get; set; }

		[DataMember]
		public PersonalInfo PersonalInfo
		{
			get { return _PersonalInfo; }
			set
			{
				if (Equals(value, _PersonalInfo)) return;
				_PersonalInfo = value;
				PersonalInfoChangeTracker = _PersonalInfo == null ? null
					: new ChangeTrackingCollection<PersonalInfo> { _PersonalInfo };
				NotifyPropertyChanged(m => m.PersonalInfo);
			}
		}
		private PersonalInfo _PersonalInfo;
		private ChangeTrackingCollection<PersonalInfo> PersonalInfoChangeTracker { get; set; }

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

		bool IEquatable<User>.Equals(User other)
		{
			if (EntityIdentifier != default(Guid))
				return EntityIdentifier == other.EntityIdentifier;
			return false;
		}
        #endregion
	}
}
