using System.Data.Entity.ModelConfiguration;

namespace AIM.Application.Service.Entities.Models.Mapping
{
    public class OpenJobMap : EntityTypeConfiguration<OpenJob>
    {
        public OpenJobMap()
        {
            // Primary Key
            this.HasKey(t => t.openJobsId);

            // Properties
            // Table & Column Mappings
            this.ToTable("OpenJobs");
            this.Property(t => t.openJobsId).HasColumnName("openJobsId");
            this.Property(t => t.jobId).HasColumnName("jobId");
            this.Property(t => t.storeId).HasColumnName("storeId");
            this.Property(t => t.regionId).HasColumnName("regionId");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);

            // Relationships
            this.HasRequired(t => t.Job)
                .WithMany(t => t.OpenJobs)
                .HasForeignKey(d => d.jobId);
            this.HasRequired(t => t.Store)
                .WithMany(t => t.OpenJobs)
                .HasForeignKey(d => d.storeId);
            this.HasRequired(t => t.Region)
                .WithMany(t => t.OpenJobs)
                .HasForeignKey(d => d.regionId);
        }
    }
}