using System.Data.Entity.ModelConfiguration;

namespace AIM.Service.Entities.Models.Mapping
{
    public class QuestionnaireMap : EntityTypeConfiguration<Questionnaire>
    {
        public QuestionnaireMap()
        {
            // Primary Key
            this.HasKey(t => t.questionnaireId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Questionnaires");
            this.Property(t => t.questionnaireId).HasColumnName("questionnaireId");
            this.Property(t => t.questionId).HasColumnName("questionId");
            this.Property(t => t.jobId).HasColumnName("jobId");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);
        }
    }
}