using AIM.Application.Service.Entities.Models.Mapping;
using System.Data.Entity;

namespace AIM.Application.Service.Entities.Models
{
    public partial class AIM_DBContext : DbContext
    {
        static AIM_DBContext()
        {
            Database.SetInitializer<AIM_DBContext>(null);
        }

        public AIM_DBContext()
            : base("Name=AIM_DBContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<ApplicantQuestionAnswer> ApplicantQuestionAnswers { get; set; }

        public DbSet<Applicant> Applicants { get; set; }

        public DbSet<Application> Applications { get; set; }

        public DbSet<Education> Educations { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Hour> Hours { get; set; }

        public DbSet<InterviewQuestion> InterviewQuestions { get; set; }

        public DbSet<JobHistory> JobHistories { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<OpenJob> OpenJobs { get; set; }

        public DbSet<PersonalInfo> PersonalInfoes { get; set; }

        public DbSet<QuestionInterviewQuestionMapping> QuestionInterviewQuestionMappings { get; set; }

        public DbSet<Questionnaire> Questionnaires { get; set; }

        public DbSet<QuestionQuestionnaire> QuestionQuestionnaires { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Reference> References { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Store> Stores { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ApplicantQuestionAnswerMap());
            modelBuilder.Configurations.Add(new ApplicantMap());
            modelBuilder.Configurations.Add(new ApplicationMap());
            modelBuilder.Configurations.Add(new EducationMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new HourMap());
            modelBuilder.Configurations.Add(new InterviewQuestionMap());
            modelBuilder.Configurations.Add(new JobHistoryMap());
            modelBuilder.Configurations.Add(new JobMap());
            modelBuilder.Configurations.Add(new OpenJobMap());
            modelBuilder.Configurations.Add(new PersonalInfoMap());
            modelBuilder.Configurations.Add(new QuestionInterviewQuestionMappingMap());
            modelBuilder.Configurations.Add(new QuestionnaireMap());
            modelBuilder.Configurations.Add(new QuestionQuestionnaireMap());
            modelBuilder.Configurations.Add(new QuestionMap());
            modelBuilder.Configurations.Add(new ReferenceMap());
            modelBuilder.Configurations.Add(new RegionMap());
            modelBuilder.Configurations.Add(new StoreMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}