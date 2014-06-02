namespace AIM.Application.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AIM_DBContext : DbContext
    {
        public AIM_DBContext()
            : base("name=AIM_DBContext")
        {
        }

        public virtual DbSet<ApplicantQuestionAnswer> ApplicantQuestionAnswers { get; set; }
        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Hour> Hours { get; set; }
        public virtual DbSet<InterviewQuestion> InterviewQuestions { get; set; }
        public virtual DbSet<JobHistory> JobHistories { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<OpenJob> OpenJobs { get; set; }
        public virtual DbSet<PersonalInfo> PersonalInfoes { get; set; }
        public virtual DbSet<Questionnaire> Questionnaires { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Reference> References { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicantQuestionAnswer>()
                .Property(e => e.AnswerJsonString)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.AspNetUser)
                .HasForeignKey(e => e.AspNetUsersId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<InterviewQuestion>()
                .HasMany(e => e.Jobs)
                .WithOptional(e => e.InterviewQuestion)
                .HasForeignKey(e => e.InterviewQuestionId);

            modelBuilder.Entity<InterviewQuestion>()
                .HasMany(e => e.Questions)
                .WithMany(e => e.InterviewQuestions)
                .Map(m => m.ToTable("QuestionInterviewQuestionMappings").MapLeftKey("InterviewQuestionsId").MapRightKey("QuestionId"));

            modelBuilder.Entity<JobHistory>()
                .Property(e => e.StartingSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<JobHistory>()
                .Property(e => e.EndingSalary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.OpenJobs)
                .WithRequired(e => e.Job)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.ApplicantQuestionAnswers)
                .WithOptional(e => e.Question)
                .HasForeignKey(e => e.QuesitonId);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.Questionnaires)
                .WithMany(e => e.Questions)
                .Map(m => m.ToTable("QuestionQuestionnaires").MapLeftKey("QuestionId").MapRightKey("QuestionnaireId"));

            modelBuilder.Entity<Region>()
                .HasMany(e => e.OpenJobs)
                .WithRequired(e => e.Region)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.OpenJobs)
                .WithRequired(e => e.Store)
                .WillCascadeOnDelete(false);
        }
    }
}
