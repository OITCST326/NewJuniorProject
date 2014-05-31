using System.Data.Entity.ModelConfiguration;

namespace AIM.Service.Entities.Models.Mapping
{
    public class JobHistoryMap : EntityTypeConfiguration<JobHistory>
    {
        public JobHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.jobHistoryId);

            // Properties
            this.Property(t => t.employerName)
                .HasMaxLength(50);

            this.Property(t => t.position)
                .HasMaxLength(50);

            this.Property(t => t.supervisor)
                .HasMaxLength(50);

            this.Property(t => t.street)
                .HasMaxLength(100);

            this.Property(t => t.street2)
                .HasMaxLength(100);

            this.Property(t => t.city)
                .HasMaxLength(50);

            this.Property(t => t.zip)
                .HasMaxLength(5);

            this.Property(t => t.phone)
                .HasMaxLength(13);

            // Table & Column Mappings
            this.ToTable("JobHistories");
            this.Property(t => t.jobHistoryId).HasColumnName("jobHistoryId");
            this.Property(t => t.employerName).HasColumnName("employerName");
            this.Property(t => t.position).HasColumnName("position");
            this.Property(t => t.responsibilities).HasColumnName("responsibilities");
            this.Property(t => t.supervisor).HasColumnName("supervisor");
            this.Property(t => t.startingSalary).HasColumnName("startingSalary");
            this.Property(t => t.endingSalary).HasColumnName("endingSalary");
            this.Property(t => t.reasonForLeaving).HasColumnName("reasonForLeaving");
            this.Property(t => t.dateFrom).HasColumnName("dateFrom");
            this.Property(t => t.dateTo).HasColumnName("dateTo");
            this.Property(t => t.street).HasColumnName("street");
            this.Property(t => t.street2).HasColumnName("street2");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.zip).HasColumnName("zip");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.applicantId).HasColumnName("applicantId");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);

            // Relationships
            this.HasOptional(t => t.Applicant)
                .WithMany(t => t.JobHistories)
                .HasForeignKey(d => d.applicantId);
        }
    }
}