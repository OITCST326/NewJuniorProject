using System.Data.Entity.ModelConfiguration;

namespace AIM.Application.Service.Entities.Models.Mapping
{
    public class StoreMap : EntityTypeConfiguration<Store>
    {
        public StoreMap()
        {
            // Primary Key
            this.HasKey(t => t.storeId);

            // Properties
            this.Property(t => t.name)
                .HasMaxLength(40);

            this.Property(t => t.street)
                .HasMaxLength(100);

            this.Property(t => t.street2)
                .HasMaxLength(100);

            this.Property(t => t.city)
                .HasMaxLength(50);

            this.Property(t => t.zip)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("Store");
            this.Property(t => t.storeId).HasColumnName("storeId");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.regionId).HasColumnName("regionId");
            this.Property(t => t.street).HasColumnName("street");
            this.Property(t => t.street2).HasColumnName("street2");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.zip).HasColumnName("zip");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);

            // Relationships
            this.HasOptional(t => t.Region)
                .WithMany(t => t.Stores)
                .HasForeignKey(d => d.regionId);
        }
    }
}