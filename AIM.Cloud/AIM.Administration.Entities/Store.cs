namespace AIM.Administration.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Store")]
    public partial class Store
    {
        public Store()
        {
            OpenJobs = new HashSet<OpenJob>();
        }

        public int StoreId { get; set; }

        [StringLength(40)]
        public string Name { get; set; }

        public int? RegionId { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(100)]
        public string Street2 { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        public int? State { get; set; }

        [StringLength(5)]
        public string Zip { get; set; }

        public virtual ICollection<OpenJob> OpenJobs { get; set; }

        public virtual Region Region { get; set; }
    }
}
