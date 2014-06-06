using System.Data.Entity.ModelConfiguration;

namespace AIM.Application.Service.Entities.Models.Mapping
{
    public class InterviewQuestionMap : EntityTypeConfiguration<InterviewQuestion>
    {
        public InterviewQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.interviewQuestionsId);

            // Properties
            // Table & Column Mappings
            this.ToTable("InterviewQuestions");
            this.Property(t => t.interviewQuestionsId).HasColumnName("interviewQuestionsId");
            this.Property(t => t.questionId).HasColumnName("questionId");
            this.Property(t => t.jobId).HasColumnName("jobId");

            // Tracking Properties
            this.Ignore(t => t.TrackingState);
            this.Ignore(t => t.ModifiedProperties);
        }
    }
}