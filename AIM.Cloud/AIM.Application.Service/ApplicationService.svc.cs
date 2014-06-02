using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using AIM.Application.Entities;

namespace AIM.Application.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ApplicationService : IApplicationService
    {
        private readonly AIM_DBContext _dbContext;

        public ApplicationService()
        {
            _dbContext = new AIM_DBContext();
        }

        /********************************************************************************************************************************/
        /*                               Applicant Model Implementation calls for Application Service                                */
        /********************************************************************************************************************************/

        /// <summary>
        /// Applicant Model Implementation calls for Application Service
        /// </summary>
        /// <seealso cref="AIM.Application.Service.ApplicationService"/>
        /// <seealso cref="..GetApplicantsList"/>
        /// <seealso cref="..GetApplicant"/>
        /// <seealso cref="..UpdateApplicant"/>
        /// <seealso cref="..CreateApplicant"/>
        /// <seealso cref="..DeleteApplicant"/>
        #region

        /// <summary>
        /// Returns a list of all Applicants including related tables; Users, PersonalInfo,
        /// hours, JobHistory, Educations, and References
        /// </summary>
        /// <returns>List of all Applicants</returns>
        /// <seealso cref="AIM.Application.Service.ApplicationService.GetApplicantsList"/>
        public async Task<IEnumerable<Applicant>> GetApplicantsList()
        {
            IEnumerable<Applicant> entities = await _dbContext.Applicants
                .Include(a => a.Applications)
                .Include(a => a.Users)
                .Include(a => a.Users.Select(p => p.PersonalInfo))
                .Include(a => a.Hours)
                .Include(a => a.JobHistories)
                .Include(a => a.Educations)
                .Include(a => a.References)
                .ToListAsync();
            return entities;
        }

        public async Task<Applicant> GetApplicant(int id)
        {
            Applicant entity = await _dbContext.Applicants
                .Include(a => a.Applications)
                .Include(a => a.Users)
                .Include(a => a.Users.Select(p => p.PersonalInfo))
                .Include(a => a.Hours).Include(a => a.JobHistories)
                .Include(a => a.Educations)
                .Include(a => a.References)
                .SingleOrDefaultAsync(x => x.ApplicantId == id);
            return entity;
        }

        public async Task<Applicant> UpdateApplicant(Applicant entity)
        {
            try
            {
                await _dbContext.SaveChangesAsync();

                // Load applicant details
                var ctx = ((IObjectContextAdapter)_dbContext).ObjectContext;
                foreach (var detail in entity.Applications)
                    ctx.LoadProperty(detail, a => a.Applicant);
                foreach (var detail in entity.Users)
                    ctx.LoadProperty(detail, a => a.Applicant);
                ctx.LoadProperty(entity, u => u.Users.Select(p => p.PersonalInfo));
                foreach (var detail in entity.Hours)
                    ctx.LoadProperty(detail, a => a.Applicant);
                foreach (var detail in entity.JobHistories)
                    ctx.LoadProperty(detail, a => a.Applicant);
                foreach (var detail in entity.Educations)
                    ctx.LoadProperty(detail, a => a.Applicant);
                foreach (var detail in entity.References)
                    ctx.LoadProperty(detail, a => a.Applicant);
                return entity;
            }
            catch (DbUpdateConcurrencyException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }
        }

        public async Task<Applicant> CreateApplicant(Applicant entity)
        {
            _dbContext.Applicants.Add(entity);
            await _dbContext.SaveChangesAsync();

            // Load applicant details
            var ctx = ((IObjectContextAdapter)_dbContext).ObjectContext;
            foreach (var detail in entity.Applications)
                ctx.LoadProperty(detail, a => a.Applicant);
            foreach (var detail in entity.Users)
                ctx.LoadProperty(detail, a => a.Applicant);
            ctx.LoadProperty(entity, u => u.Users.Select(p => p.PersonalInfo));
            foreach (var detail in entity.Hours)
                ctx.LoadProperty(detail, a => a.Applicant);
            foreach (var detail in entity.JobHistories)
                ctx.LoadProperty(detail, a => a.Applicant);
            foreach (var detail in entity.Educations)
                ctx.LoadProperty(detail, a => a.Applicant);
            foreach (var detail in entity.References)
                ctx.LoadProperty(detail, a => a.Applicant);
            return entity;
        }

        public async Task<bool> DeleteApplicant(int id)
        {
            Applicant entity = await _dbContext.Applicants
                .Include(a => a.Applications)
                .Include(a => a.Users)
                .Include(a => a.Users.Select(p => p.PersonalInfo))
                .Include(a => a.Hours)
                .Include(a => a.JobHistories)
                .Include(a => a.Educations)
                .Include(a => a.References)
                .SingleOrDefaultAsync(x => x.ApplicantId == id);
            if (entity == null)
                return false;

            try
            {
                // First remove applicant
                _dbContext.Applicants.Attach(entity);
                _dbContext.Applicants.Remove(entity);

                // Then applicant details
                foreach (var detail in entity.Applications)
                {
                    _dbContext.Applications.Attach(detail);
                    _dbContext.Applications.Remove(detail);
                }
                foreach (var detail in entity.Users)
                {
                    _dbContext.Users.Attach(detail);
                    _dbContext.Users.Remove(detail);
                }
                foreach (var detail in entity.Users.Select(p => p.PersonalInfo))
                {
                    _dbContext.PersonalInfoes.Attach(detail);
                    _dbContext.PersonalInfoes.Remove(detail);
                }
                foreach (var detail in entity.Hours)
                {
                    _dbContext.Hours.Attach(detail);
                    _dbContext.Hours.Remove(detail);
                }
                foreach (var detail in entity.JobHistories)
                {
                    _dbContext.JobHistories.Attach(detail);
                    _dbContext.JobHistories.Remove(detail);
                }
                foreach (var detail in entity.Educations)
                {
                    _dbContext.Educations.Attach(detail);
                    _dbContext.Educations.Remove(detail);
                }
                foreach (var detail in entity.References)
                {
                    _dbContext.References.Attach(detail);
                    _dbContext.References.Remove(detail);
                }
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }
        }

        #endregion

        /********************************************************************************************************************************/
        /*                                   Job Model Implementation calls for Application Service                                  */
        /********************************************************************************************************************************/

        /// <summary>
        /// Job Model Implementation calls for Application Service
        /// </summary>
        /// <seealso cref="AIM.Application.Service.ApplicationService"/>
        /// <seealso cref="..GetJobsList"/>
        /// <seealso cref="..GetJob"/>
        /// <seealso cref="..UpdateJob"/>
        /// <seealso cref="..CreateJob"/>
        /// <seealso cref="..DeleteJob"/>
        #region

        public async Task<IEnumerable<Job>> GetJobsList()
        {
            IEnumerable<Job> entities = await _dbContext.Jobs
                .OrderBy(j => j.Description)
                .Include(j => j.Hour)
                .Include(j => j.Questionnaire)
                .ToListAsync();
            return entities;
        }

        public async Task<Job> GetJob(int? id)
        {
            Job entity = await _dbContext.Jobs
                .OrderBy(j => j.Description)
                .Include(j => j.Hour)
                .Include(j => j.Questionnaire)
                .SingleOrDefaultAsync(x => x.JobId == id);
            return entity;
        }

        public async Task<Job> UpdateJob(Job entity)
        {
            try
            {
                await _dbContext.SaveChangesAsync();
                return entity;
            }
            catch (DbUpdateConcurrencyException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }
        }

        public async Task<Job> CreateJob(Job entity)
        {
            _dbContext.Jobs.Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteJob(int id)
        {
            Job entity = await _dbContext.Jobs
                .SingleOrDefaultAsync(x => x.JobId == id);
            if (entity == null)
                return false;

            try
            {
                _dbContext.Jobs.Attach(entity);
                _dbContext.Jobs.Remove(entity);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }
        }

        #endregion

        /********************************************************************************************************************************/
        /*                                Open Job Model Implementation calls for Application Service                                */
        /********************************************************************************************************************************/

        /// <summary>
        /// Open Job Model Implementation calls for Application Service
        /// </summary>
        /// <seealso cref="AIM.Application.Service.ApplicationService"/>
        /// <seealso cref="..GetOpenJobsList"/>
        /// <seealso cref="..GetOpenJob"/>
        /// <seealso cref="..UpdateOpenJob"/>
        /// <seealso cref="..CreateOpenJob"/>
        /// <seealso cref="..DeleteOpenJob"/>
        #region

        public async Task<IEnumerable<OpenJob>> GetOpenJobs()
        {
            IEnumerable<OpenJob> entities = await _dbContext.OpenJobs
                .Include(op => op.Region)
                .Include(op => op.Store)
                .Include(op => op.Job)
                .OrderBy(op => op.Region.RegionName)
                .ThenBy(op => op.Job.Description)
                .ToListAsync();
            return entities;
        }

        public async Task<IEnumerable<OpenJob>> GetOpenJobsForStore(int? id)
        {
            IEnumerable<OpenJob> entities = await _dbContext.OpenJobs
                .Include(op => op.Region)
                .Include(op => op.Store)
                .Include(op => op.Job)
                .Where(x => x.StoreId == id)
                .ToListAsync();
            return entities;
        }

        #endregion

        /********************************************************************************************************************************/
        /*                             Personal Info Model Implementation calls for Application Service                              */
        /********************************************************************************************************************************/

        /// <summary>
        /// Personal Info Model Implementation calls for Application Service
        /// </summary>
        /// <seealso cref="AIM.Application.Service.ApplicationService"/>
        /// <seealso cref="..GetPersonalInfoList"/>
        /// <seealso cref="..GetPersonalInfoJob"/>
        /// <seealso cref="..UpdatePersonalInfo"/>
        /// <seealso cref="..CreatePersonalInfo"/>
        /// <seealso cref="..DeletePersonalInfo"/>
        #region

        public async Task<IEnumerable<PersonalInfo>> GetPersonalInfoList()
        {
            IEnumerable<PersonalInfo> entities = await _dbContext.PersonalInfoes
                .ToListAsync();
            return entities;
        }

        public async Task<PersonalInfo> GetPersonalInfo(int? id)
        {
            PersonalInfo entity = await _dbContext.PersonalInfoes
                .Include(p => p.Users)
                .SingleOrDefaultAsync(x => x.PersonalInfoId == id);
            return entity;
        }

        public async Task<PersonalInfo> UpdatePersonalInfo(PersonalInfo entity)
        {
            try
            {
                await _dbContext.SaveChangesAsync();
                return entity;
            }
            catch (DbUpdateConcurrencyException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }
        }

        public async Task<PersonalInfo> CreatePersonalInfo(PersonalInfo entity)
        {
            _dbContext.PersonalInfoes.Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> DeletePersonalInfo(int id)
        {
            PersonalInfo entity = await _dbContext.PersonalInfoes
                .SingleOrDefaultAsync(x => x.PersonalInfoId == id);
            if (entity == null)
                return false;

            try
            {
                _dbContext.PersonalInfoes.Attach(entity);
                _dbContext.PersonalInfoes.Remove(entity);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }
        }

        #endregion

        /********************************************************************************************************************************/
        /*                                Question Model Implementation calls for Application Service                                */
        /********************************************************************************************************************************/

        /// <summary>
        /// Question Model Implementation calls for Application Service
        /// </summary>
        /// <seealso cref="AIM.Application.Service.ApplicationService"/>
        /// <seealso cref="..GetQuestionsList"/>
        /// <seealso cref="..GetQuestion"/>
        /// <seealso cref="..UpdateQuestion"/>
        /// <seealso cref="..CreateQuestion"/>
        /// <seealso cref="..DeleteQuestion"/>
        #region

        public async Task<IEnumerable<Question>> GetQuestionsList()
        {
            IEnumerable<Question> entities = await _dbContext.Questions
                .OrderBy(q => q.QJsonProperties)
                .ToListAsync();
            return entities;
        }

        public async Task<Question> GetQuestion(int id)
        {
            Question entity = await _dbContext.Questions
                .SingleOrDefaultAsync(x => x.QuestionId == id);
            return entity;
        }

        public async Task<Question> UpdateQuestion(Question entity)
        {
            try
            {
                await _dbContext.SaveChangesAsync();
                return entity;
            }
            catch (DbUpdateConcurrencyException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }
        }

        public async Task<Question> CreateQuestion(Question entity)
        {
            _dbContext.Questions.Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteQuestion(int id)
        {
            Question entity = await _dbContext.Questions
                .SingleOrDefaultAsync(x => x.QuestionId == id);
            if (entity == null)
                return false;

            try
            {
                _dbContext.Questions.Attach(entity);
                _dbContext.Questions.Remove(entity);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }
        }

        #endregion

        /********************************************************************************************************************************/
        /*                             Questionnaire Model Implementation calls for Application Service                              */
        /********************************************************************************************************************************/

        /// <summary>
        /// Questionnaire Model Implementation calls for Application Service
        /// </summary>
        /// <seealso cref="AIM.Application.Service.ApplicationService"/>
        /// <seealso cref="..GetQuestionnairesList"/>
        /// <seealso cref="..GetQuestionnaire"/>
        /// <seealso cref="..UpdateQuestionnaire"/>
        /// <seealso cref="..CreateQuestionnaire"/>
        /// <seealso cref="..DeleteQuestionnaire"/>
        #region

        public async Task<IEnumerable<Questionnaire>> GetQuestionnairesList()
        {
            IEnumerable<Questionnaire> entities = await _dbContext.Questionnaires
                .ToListAsync();
            return entities;
        }

        public async Task<Questionnaire> GetQuestionnaire(int id)
        {
            Questionnaire entity = await _dbContext.Questionnaires
                .SingleOrDefaultAsync(x => x.QuestionnaireId == id);
            return entity;
        }

        public async Task<Questionnaire> UpdateQuestionnaire(Questionnaire entity)
        {
            try
            {
                await _dbContext.SaveChangesAsync();
                return entity;
            }
            catch (DbUpdateConcurrencyException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }
        }

        public async Task<Questionnaire> CreateQuestionnaire(Questionnaire entity)
        {
            _dbContext.Questionnaires.Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteQuestionnaire(int id)
        {
            Questionnaire entity = await _dbContext.Questionnaires
                .SingleOrDefaultAsync(x => x.QuestionnaireId == id);
            if (entity == null)
                return false;

            try
            {
                _dbContext.Questionnaires.Attach(entity);
                _dbContext.Questionnaires.Remove(entity);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }
        }

        #endregion

        /********************************************************************************************************************************/
        /*                                 Region Model Implementation calls for Application Service                                 */
        /********************************************************************************************************************************/

        /// <summary>
        /// Region Model Implementation calls for Application Service
        /// </summary>
        /// <seealso cref="AIM.Application.Service.ApplicationService"/>
        /// <seealso cref="..GetRegionList"/>
        #region

        public async Task<IEnumerable<Region>> GetRegionList()
        {
            IEnumerable<Region> entities = await _dbContext.Regions
                .OrderBy(r => r.RegionName)
                .ToListAsync();
            return entities;
        }

        #endregion

        /********************************************************************************************************************************/
        /*                                  Store Model Implementation calls for Application Service                                 */
        /********************************************************************************************************************************/

        /// <summary>
        /// Store Model Implementation calls for Application Service
        /// </summary>
        /// <seealso cref="AIM.Application.Service.ApplicationService"/>
        /// <seealso cref="..GetStoreList"/>
        #region

        public async Task<IEnumerable<Store>> GetStoreList(int? region)
        {
            IEnumerable<Store> entities = await _dbContext.Stores
                .Where(op => op.RegionId == region)
                .OrderBy(op => op.RegionId)
                .ThenBy(op => op.Name)
                .ToListAsync();
            return entities;
        }

        #endregion

        /********************************************************************************************************************************/
        /*                                  User Model Implementation calls for Application Service                                  */
        /********************************************************************************************************************************/

        /// <summary>
        /// User Model Implementation calls for Application Service
        /// </summary>
        /// <seealso cref="AIM.Application.Service.ApplicationService"/>
        /// <seealso cref="..GetUsersList"/>
        /// <seealso cref="..GetUser"/>
        /// <seealso cref="..GetUserLogin"/>
        /// <seealso cref="..UpdateUser"/>
        /// <seealso cref="..CreateUser"/>
        /// <seealso cref="..DeleteUser"/>
        #region

        public async Task<IEnumerable<User>> GetUsersList()
        {
            IEnumerable<User> entities = await _dbContext.Users
                .OrderBy(u => u.FirstName)
                .ThenBy(u => u.LastName)
                .Include(u => u.Applicant)
                .Include(u => u.Employee)
                .Include(u => u.PersonalInfo)
                .ToListAsync();
            return entities;
        }

        public async Task<User> GetUser(int? id)
        {
            User entity = await _dbContext.Users
                .SingleOrDefaultAsync(x => x.UserId == id);
            return entity;
        }
        public async Task<User> GetUserLogin(string userName, string passowrd)
        {
            User entity = await _dbContext.Users
                .Where(x => x.UserName == userName)
                .Where(x => x.Password == passowrd)
                .SingleOrDefaultAsync();
            return entity;
        }


        public async Task<User> UpdateUser(User entity)
        {
            try
            {
                await _dbContext.SaveChangesAsync();
                return entity;
            }
            catch (DbUpdateConcurrencyException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }
        }

        public async Task<User> CreateUser(User entity)
        {
            _dbContext.Users.Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteUser(int id)
        {
            User entity = await _dbContext.Users
                .SingleOrDefaultAsync(x => x.UserId == id);
            if (entity == null)
                return false;

            try
            {
                _dbContext.Users.Attach(entity);
                _dbContext.Users.Remove(entity);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }
        }

        #endregion

        public void Dispose()
        {
            var dispose = _dbContext as IDisposable;
            if (dispose != null)
            {
                _dbContext.Dispose();
            }
        }
    }
}
