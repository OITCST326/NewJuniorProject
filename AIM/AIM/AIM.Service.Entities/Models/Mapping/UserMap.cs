using System.Data.Entity.ModelConfiguration;

namespace AIM.Service.Entities.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.userId);

            // Properties
            this.Property(t => t.firstName)
                .HasMaxLength(25);

            this.Property(t => t.middleName)
                .HasMaxLength(25);

            this.Property(t => t.lastName)
                .HasMaxLength(40);

            this.Property(t => t.email)
                .HasMaxLength(100);

            this.Property(t => t.socialSecurityNumber)
                .HasMaxLength(11);

            this.Property(t => t.userName)
                .HasMaxLength(40);

            this.Property(t => t.password)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("Users");
            this.Property(t => t.userId).HasColumnName("userId");
            this.Property(t => t.firstName).HasColumnName("firstName");
            this.Property(t => t.middleName).HasColumnName("middleName");
            this.Property(t => t.lastName).HasColumnName("lastName");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.socialSecurityNumber).HasColumnName("socialSecurityNumber");
            this.Property(t => t.PersonalInfoId).HasColumnName("PersonalInfoId");
            this.Property(t => t.applicantId).HasColumnName("applicantId");
            this.Property(t => t.applicationId).HasColumnName("applicationId");
            this.Property(t => t.employeeId).HasColumnName("employeeId");
            this.Property(t => t.userName).HasColumnName("userName");
            this.Property(t => t.password).HasColumnName("password");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);

            // Relationships
            this.HasOptional(t => t.Applicant)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.applicantId);
            this.HasOptional(t => t.Employee)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.employeeId);
            this.HasOptional(t => t.PersonalInfo)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.PersonalInfoId);
        }
    }
}