using System.Data.Entity.ModelConfiguration;

namespace AIM.Application.Service.Entities.Models.Mapping
{
    public class ApplicantQuestionAnswerMap : EntityTypeConfiguration<ApplicantQuestionAnswer>
    {
        public ApplicantQuestionAnswerMap()
        {
            // Primary Key
            this.HasKey(t => t.answerId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ApplicantQuestionAnswers");
            this.Property(t => t.answerId).HasColumnName("answerId");
            this.Property(t => t.applicantId).HasColumnName("applicantId");
            this.Property(t => t.quesitonId).HasColumnName("quesitonId");
            this.Property(t => t.answerJsonString).HasColumnName("answerJsonString");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);

            // Relationships
            this.HasOptional(t => t.Applicant)
                .WithMany(t => t.ApplicantQuestionAnswers)
                .HasForeignKey(d => d.applicantId);
            this.HasOptional(t => t.Question)
                .WithMany(t => t.ApplicantQuestionAnswers)
                .HasForeignKey(d => d.quesitonId);
        }
    }
}