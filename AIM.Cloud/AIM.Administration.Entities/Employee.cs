namespace AIM.Administration.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        public Employee()
        {
            Users = new HashSet<User>();
        }

        public int EmployeeId { get; set; }

        public int? Permissions { get; set; }

        public int? JobId { get; set; }

        public virtual Job Job { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
