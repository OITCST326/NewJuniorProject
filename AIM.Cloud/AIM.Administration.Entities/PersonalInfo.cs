namespace AIM.Administration.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PersonalInfo
    {
        public PersonalInfo()
        {
            Users = new HashSet<User>();
        }

        public int PersonalInfoId { get; set; }

        [StringLength(25)]
        public string Alias { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(100)]
        public string Street2 { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        public int? State { get; set; }

        [StringLength(5)]
        public string Zip { get; set; }

        [StringLength(13)]
        public string Phone { get; set; }

        public int? UserId { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
