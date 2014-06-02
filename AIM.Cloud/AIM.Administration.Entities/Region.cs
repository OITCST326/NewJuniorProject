namespace AIM.Administration.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Region")]
    public partial class Region
    {
        public Region()
        {
            OpenJobs = new HashSet<OpenJob>();
            Stores = new HashSet<Store>();
        }

        public int RegionId { get; set; }

        [StringLength(40)]
        public string RegionName { get; set; }

        public virtual ICollection<OpenJob> OpenJobs { get; set; }

        public virtual ICollection<Store> Stores { get; set; }
    }
}
