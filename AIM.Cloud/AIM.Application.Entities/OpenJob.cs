namespace AIM.Application.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OpenJob
    {
        [Key]
        public int OpenJobsId { get; set; }

        public int JobId { get; set; }

        public int StoreId { get; set; }

        public int RegionId { get; set; }

        public bool? IsApproved { get; set; }

        public virtual Job Job { get; set; }

        public virtual Store Store { get; set; }

        public virtual Region Region { get; set; }
    }
}
