using System.Data.Entity.ModelConfiguration;

namespace AIM.Service.Entities.Models.Mapping
{
    public class HourMap : EntityTypeConfiguration<Hour>
    {
        public HourMap()
        {
            // Primary Key
            this.HasKey(t => t.hoursId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Hours");
            this.Property(t => t.hoursId).HasColumnName("hoursId");
            this.Property(t => t.applicantId).HasColumnName("applicantId");
            this.Property(t => t.monOpen).HasColumnName("monOpen");
            this.Property(t => t.monClose).HasColumnName("monClose");
            this.Property(t => t.tueOpen).HasColumnName("tueOpen");
            this.Property(t => t.tueClose).HasColumnName("tueClose");
            this.Property(t => t.wedOpen).HasColumnName("wedOpen");
            this.Property(t => t.wedClose).HasColumnName("wedClose");
            this.Property(t => t.thursOpen).HasColumnName("thursOpen");
            this.Property(t => t.thursClose).HasColumnName("thursClose");
            this.Property(t => t.friOpen).HasColumnName("friOpen");
            this.Property(t => t.friClose).HasColumnName("friClose");
            this.Property(t => t.satOpen).HasColumnName("satOpen");
            this.Property(t => t.satClose).HasColumnName("satClose");
            this.Property(t => t.sunOpen).HasColumnName("sunOpen");
            this.Property(t => t.sunClose).HasColumnName("sunClose");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);

            // Relationships
            this.HasOptional(t => t.Applicant)
                .WithMany(t => t.Hours)
                .HasForeignKey(d => d.applicantId);
        }
    }
}