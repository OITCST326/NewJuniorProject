using System.Data.Entity.ModelConfiguration;

namespace AIM.Admin.Service.WorkerRole.Models.Mapping
{
    public class ApplicantQuestionAnswerMap : EntityTypeConfiguration<ApplicantQuestionAnswer>
    {
        public ApplicantQuestionAnswerMap()
        {
            // Primary Key
            this.HasKey(t => t.AnswerId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ApplicantQuestionAnswers");
            this.Property(t => t.AnswerId).HasColumnName("AnswerId");
            this.Property(t => t.ApplicantId).HasColumnName("ApplicantId");
            this.Property(t => t.QuesitonId).HasColumnName("QuesitonId");
            this.Property(t => t.AnswerJsonString).HasColumnName("AnswerJsonString");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);

            // Relationships
            this.HasOptional(t => t.Applicant)
                .WithMany(t => t.ApplicantQuestionAnswers)
                .HasForeignKey(d => d.ApplicantId);
            this.HasOptional(t => t.Question)
                .WithMany(t => t.ApplicantQuestionAnswers)
                .HasForeignKey(d => d.QuesitonId);
        }
    }
}