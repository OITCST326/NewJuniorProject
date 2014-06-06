using AIM.Application.Service.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using TrackableEntities.Common;
using TrackableEntities.EF6;

namespace AIM.Application.Service.Core
{
    [ServiceContract(Namespace = "urn:trackable-entities:service")]
    public interface IApplicationService
    {
        [OperationContract]
        Task<IEnumerable<Applicant>> GetApplicantsList();

        [OperationContract]
        Task<Applicant> GetApplicant(int id);

        [OperationContract]
        Task<Applicant> UpdateApplicant(Applicant entity);

        [OperationContract]
        Task<Applicant> CreateApplicant(Applicant entity);

        [OperationContract]
        Task<bool> DeleteApplicant(int id);
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ApplicationService : IApplicationService, IDisposable
    {
        private readonly AIM_DBContext _dbContext;

        public ApplicationService()
        {
            _dbContext = new AIM_DBContext();
        }

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
                .SingleOrDefaultAsync(x => x.applicantId == id);
            return entity;
        }

        public async Task<Applicant> UpdateApplicant(Applicant entity)
        {
            try
            {
                _dbContext.ApplyChanges(entity);
                await _dbContext.SaveChangesAsync();
                entity.AcceptChanges();

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
            entity.AcceptChanges();

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
                .SingleOrDefaultAsync(x => x.applicantId == id);
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