namespace AIM.Administration.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public int UserId { get; set; }

        [StringLength(25)]
        public string FirstName { get; set; }

        [StringLength(25)]
        public string MiddleName { get; set; }

        [StringLength(40)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(11)]
        public string SocialSecurityNumber { get; set; }

        public int? PersonalInfoId { get; set; }

        public int? ApplicantId { get; set; }

        public int? ApplicationId { get; set; }

        public int? EmployeeId { get; set; }

        [StringLength(256)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(128)]
        public string AspNetUsersId { get; set; }

        public virtual Applicant Applicant { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual PersonalInfo PersonalInfo { get; set; }
    }
}
