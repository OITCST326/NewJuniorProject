using System.Data.Entity.ModelConfiguration;

namespace AIM.Application.Service.Entities.Models.Mapping
{
    public class JobMap : EntityTypeConfiguration<Job>
    {
        public JobMap()
        {
            // Primary Key
            this.HasKey(t => t.jobId);

            // Properties
            this.Property(t => t.position)
                .HasMaxLength(150);

            this.Property(t => t.fullPartTime)
                .HasMaxLength(50);

            this.Property(t => t.salaryRange)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Jobs");
            this.Property(t => t.jobId).HasColumnName("jobId");
            this.Property(t => t.position).HasColumnName("position");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.fullPartTime).HasColumnName("fullPartTime");
            this.Property(t => t.salaryRange).HasColumnName("salaryRange");
            this.Property(t => t.questionnaireId).HasColumnName("questionnaireId");
            this.Property(t => t.hoursId).HasColumnName("hoursId");
            this.Property(t => t.InterviewQuestionId).HasColumnName("InterviewQuestionId");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);

            // Relationships
            this.HasOptional(t => t.Hour)
                .WithMany(t => t.Jobs)
                .HasForeignKey(d => d.hoursId);
            this.HasOptional(t => t.InterviewQuestion)
                .WithMany(t => t.Jobs)
                .HasForeignKey(d => d.InterviewQuestionId);
            this.HasOptional(t => t.Questionnaire)
                .WithMany(t => t.Jobs)
                .HasForeignKey(d => d.questionnaireId);
        }
    }
}