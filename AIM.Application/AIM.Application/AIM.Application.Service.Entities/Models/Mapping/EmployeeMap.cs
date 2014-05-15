using System.Data.Entity.ModelConfiguration;

namespace AIM.Application.Service.Entities.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.employeeId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Employees");
            this.Property(t => t.employeeId).HasColumnName("employeeId");
            this.Property(t => t.permissions).HasColumnName("permissions");
            this.Property(t => t.jobId).HasColumnName("jobId");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);

            // Relationships
            this.HasOptional(t => t.Job)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.jobId);
        }
    }
}