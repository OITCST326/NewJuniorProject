using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AIM.Application.Service.Entities.Models.Mapping
{
    public class QuestionInterviewQuestionMappingMap : EntityTypeConfiguration<QuestionInterviewQuestionMapping>
    {
        public QuestionInterviewQuestionMappingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.questionId, t.interviewQuestionsId });

            // Properties
            this.Property(t => t.questionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.interviewQuestionsId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("QuestionInterviewQuestionMappings");
            this.Property(t => t.questionId).HasColumnName("questionId");
            this.Property(t => t.interviewQuestionsId).HasColumnName("interviewQuestionsId");
            this.Property(t => t.numberOfQuestions).HasColumnName("numberOfQuestions");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);

            // Relationships
            this.HasRequired(t => t.InterviewQuestion)
                .WithMany(t => t.QuestionInterviewQuestionMappings)
                .HasForeignKey(d => d.interviewQuestionsId);
            this.HasRequired(t => t.Question)
                .WithMany(t => t.QuestionInterviewQuestionMappings)
                .HasForeignKey(d => d.questionId);
        }
    }
}