using System.Data.Entity.ModelConfiguration;

namespace AIM.Application.Service.Entities.Models.Mapping
{
    public class PersonalInfoMap : EntityTypeConfiguration<PersonalInfo>
    {
        public PersonalInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonalInfoId);

            // Properties
            this.Property(t => t.alias)
                .HasMaxLength(25);

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
            this.ToTable("PersonalInfoes");
            this.Property(t => t.PersonalInfoId).HasColumnName("PersonalInfoId");
            this.Property(t => t.alias).HasColumnName("alias");
            this.Property(t => t.street).HasColumnName("street");
            this.Property(t => t.street2).HasColumnName("street2");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.zip).HasColumnName("zip");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.userId).HasColumnName("userId");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);
        }
    }
}