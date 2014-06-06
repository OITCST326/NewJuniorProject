using System.Data.Entity.ModelConfiguration;

namespace AIM.Application.Service.Entities.Models.Mapping
{
    public class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {
            // Primary Key
            this.HasKey(t => t.regionId);

            // Properties
            this.Property(t => t.regionName)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("Region");
            this.Property(t => t.regionId).HasColumnName("regionId");
            this.Property(t => t.regionName).HasColumnName("regionName");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);
        }
    }
}