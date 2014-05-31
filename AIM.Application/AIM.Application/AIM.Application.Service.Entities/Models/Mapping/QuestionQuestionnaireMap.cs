using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AIM.Application.Service.Entities.Models.Mapping
{
    public class QuestionQuestionnaireMap : EntityTypeConfiguration<QuestionQuestionnaire>
    {
        public QuestionQuestionnaireMap()
        {
            // Primary Key
            this.HasKey(t => new { t.questionId, t.questionnaireId });

            // Properties
            this.Property(t => t.questionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.questionnaireId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("QuestionQuestionnaires");
            this.Property(t => t.questionId).HasColumnName("questionId");
            this.Property(t => t.questionnaireId).HasColumnName("questionnaireId");
            this.Property(t => t.numberOfQuestions).HasColumnName("numberOfQuestions");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);

            // Relationships
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.QuestionQuestionnaires)
                .HasForeignKey(d => d.questionnaireId);
            this.HasRequired(t => t.Question)
                .WithMany(t => t.QuestionQuestionnaires)
                .HasForeignKey(d => d.questionId);
        }
    }
}