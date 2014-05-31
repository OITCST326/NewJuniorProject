using System.Data.Entity.ModelConfiguration;

namespace AIM.Application.Service.Entities.Models.Mapping
{
    public class ReferenceMap : EntityTypeConfiguration<Reference>
    {
        public ReferenceMap()
        {
            // Primary Key
            this.HasKey(t => t.referenceId);

            // Properties
            this.Property(t => t.refFullName)
                .HasMaxLength(50);

            this.Property(t => t.refCompany)
                .HasMaxLength(50);

            this.Property(t => t.refTitle)
                .HasMaxLength(50);

            this.Property(t => t.refPhone)
                .HasMaxLength(13);

            // Table & Column Mappings
            this.ToTable("References");
            this.Property(t => t.referenceId).HasColumnName("referenceId");
            this.Property(t => t.refFullName).HasColumnName("refFullName");
            this.Property(t => t.refCompany).HasColumnName("refCompany");
            this.Property(t => t.refTitle).HasColumnName("refTitle");
            this.Property(t => t.refPhone).HasColumnName("refPhone");
            this.Property(t => t.applicantId).HasColumnName("applicantId");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);

            // Relationships
            this.HasOptional(t => t.Applicant)
                .WithMany(t => t.References)
                .HasForeignKey(d => d.applicantId);
        }
    }
}