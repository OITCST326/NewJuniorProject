/****************************** Module Header ******************************\
* Module Name:  Employee.cs
* Project:	    A.I.M. - Automated Interview Manager
* Copyright (c) 5 Programers Of Tomorrow.
*
* Employee Model.
\***************************************************************************/

namespace AIM.Application.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [JsonObject(IsReference = true)]
    [DataContract(IsReference = true)]
    [Table("Employee")]
    public partial class Employee
    {
        public Employee()
        {
            this.Users = new HashSet<User>();
        }

        // Employee Primary Key
        [DataMember]
        [Display(Name = "Employee Id")]
        public int EmployeeId { get; set; }


        // Employee Properties
        [DataMember]
        [Display(Name = "Permissions")]
        public PermissionsEnum? Permissions { get; set; }


        // Employee Table & Column Mappings
        [DataMember]
        [Display(Name = "Job Id")]
        public int? JobId { get; set; }

        [DataMember]
        [Display(Name = "Job")]
        public virtual Job Job { get; set; }

        [DataMember]
        [Display(Name = "User")]
        public virtual ICollection<User> Users { get; set; }
    }
}