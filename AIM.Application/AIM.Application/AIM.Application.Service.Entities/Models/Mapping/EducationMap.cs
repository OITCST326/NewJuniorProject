using System.Data.Entity.ModelConfiguration;

namespace AIM.Application.Service.Entities.Models.Mapping
{
    public class EducationMap : EntityTypeConfiguration<Education>
    {
        public EducationMap()
        {
            // Primary Key
            this.HasKey(t => t.educationId);

            // Properties
            this.Property(t => t.schoolName)
                .HasMaxLength(100);

            this.Property(t => t.degree)
                .HasMaxLength(100);

            this.Property(t => t.yearsAttended)
                .HasMaxLength(100);

            this.Property(t => t.street)
                .HasMaxLength(100);

            this.Property(t => t.street2)
                .HasMaxLength(100);

            this.Property(t => t.city)
                .HasMaxLength(100);

            this.Property(t => t.zip)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("Educations");
            this.Property(t => t.educationId).HasColumnName("educationId");
            this.Property(t => t.schoolName).HasColumnName("schoolName");
            this.Property(t => t.degree).HasColumnName("degree");
            this.Property(t => t.graduated).HasColumnName("graduated");
            this.Property(t => t.yearsAttended).HasColumnName("yearsAttended");
            this.Property(t => t.street).HasColumnName("street");
            this.Property(t => t.street2).HasColumnName("street2");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.zip).HasColumnName("zip");
            this.Property(t => t.applicantId).HasColumnName("applicantId");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);

            // Relationships
            this.HasOptional(t => t.Applicant)
                .WithMany(t => t.Educations)
                .HasForeignKey(d => d.applicantId);
        }
    }
}