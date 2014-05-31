using System.Data.Entity.ModelConfiguration;

namespace AIM.Service.Entities.Models.Mapping
{
    public class ApplicantMap : EntityTypeConfiguration<Applicant>
    {
        public ApplicantMap()
        {
            // Primary Key
            this.HasKey(t => t.applicantId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Applicants");
            this.Property(t => t.applicantId).HasColumnName("applicantId");
            this.Property(t => t.educationId).HasColumnName("educationId");
            this.Property(t => t.jobHistoryId).HasColumnName("jobHistoryId");
            this.Property(t => t.referenceId).HasColumnName("referenceId");
            this.Property(t => t.userId).HasColumnName("userId");
            this.Property(t => t.applicationId).HasColumnName("applicationId");
            this.Property(t => t.answerId).HasColumnName("answerId");
            this.Property(t => t.hoursId).HasColumnName("hoursId");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);
        }
    }
}