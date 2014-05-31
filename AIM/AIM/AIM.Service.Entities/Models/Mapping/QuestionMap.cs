using System.Data.Entity.ModelConfiguration;

namespace AIM.Service.Entities.Models.Mapping
{
    public class QuestionMap : EntityTypeConfiguration<Question>
    {
        public QuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.questionId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Questions");
            this.Property(t => t.questionId).HasColumnName("questionId");
            this.Property(t => t.qJsonProperties).HasColumnName("qJsonProperties");
            this.Property(t => t.questionnaireId).HasColumnName("questionnaireId");
            this.Property(t => t.interviewQuestionsId).HasColumnName("interviewQuestionsId");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);

            // Json Properties
            this.Ignore(t => t.qJsonId);
            this.Ignore(t => t.qJsonType);
            this.Ignore(t => t.qJsonText);
            this.Ignore(t => t.qJsonOptionList);
            this.Ignore(t => t.qJsonAnswerList);
        }
    }
}