using System.Data.Entity.ModelConfiguration;

namespace AIM.Application.Service.Entities.Models.Mapping
{
    public class ApplicationMap : EntityTypeConfiguration<Application>
    {
        public ApplicationMap()
        {
            // Primary Key
            this.HasKey(t => t.applicationId);

            // Properties
            this.Property(t => t.preEmploymentStatement)
                .HasMaxLength(100);

            this.Property(t => t.salaryExpectation)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Applications");
            this.Property(t => t.applicationId).HasColumnName("applicationId");
            this.Property(t => t.applicantId).HasColumnName("applicantId");
            this.Property(t => t.dateCreated).HasColumnName("dateCreated");
            this.Property(t => t.preEmploymentStatement).HasColumnName("preEmploymentStatement");
            this.Property(t => t.jobId).HasColumnName("jobId");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.salaryExpectation).HasColumnName("salaryExpectation");
            this.Property(t => t.isFullTime).HasColumnName("isFullTime");
            this.Property(t => t.isDays).HasColumnName("isDays");
            this.Property(t => t.isEvenings).HasColumnName("isEvenings");
            this.Property(t => t.isWeekends).HasColumnName("isWeekends");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);

            // Relationships
            this.HasOptional(t => t.Applicant)
                .WithMany(t => t.Applications)
                .HasForeignKey(d => d.applicantId);
            this.HasOptional(t => t.Job)
                .WithMany(t => t.Applications)
                .HasForeignKey(d => d.jobId);
        }
    }
}