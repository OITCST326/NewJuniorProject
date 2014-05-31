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
    public interface IJobService
    {
        [OperationContract]
        Task<IEnumerable<Job>> GetJobsList();

        [OperationContract]
        Task<IEnumerable<OpenJob>> GetOpenJobsList(int? id);

        [OperationContract]
        Task<Job> GetJob(int? id);

        [OperationContract]
        Task<OpenJob> GetOpenJob(int? id);

        [OperationContract]
        Task<Job> UpdateJob(Job entity);

        [OperationContract]
        Task<Job> CreateJob(Job entity);

        [OperationContract]
        Task<bool> DeleteJob(int id);

        [OperationContract]
        Task<IEnumerable<Region>> GetRegionList();

        [OperationContract]
        Task<string> GetRegionName(int? id);
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class JobService : IJobService, IDisposable
    {
        private readonly AIM_DBContext _dbContext;

        public JobService()
        {
            _dbContext = new AIM_DBContext();
        }

        public async Task<IEnumerable<Job>> GetJobsList()
        {
            IEnumerable<Job> entities = await _dbContext.Jobs
                .OrderBy(j => j.description)
                .Include(j => j.Hour)
                .Include(j => j.Questionnaire)
                .ToListAsync();
            return entities;
        }

        public async Task<IEnumerable<OpenJob>> GetOpenJobsList(int? regionID)
        {
            IEnumerable<OpenJob> entities = await _dbContext.OpenJobs
                .Include(oj => oj.Job)
                .Include(oj => oj.Region)
                .Include(oj => oj.Store)
                .Where(oj => oj.Region.regionId == regionID)
                .OrderBy(oj => oj.Job.description)
                .ToListAsync();
            return entities;
        }

        public async Task<Job> GetJob(int? id)
        {
            Job entity = await _dbContext.Jobs
                .SingleOrDefaultAsync(x => x.jobId == id);
            return entity;
        }

        public async Task<OpenJob> GetOpenJob(int? id)
        {
            OpenJob entity = await _dbContext.OpenJobs
                .Include(oj => oj.Job)
                .Include(oj => oj.Store)
                .Include(oj => oj.Region)
                .SingleOrDefaultAsync(x => x.openJobsId == id);
            return entity;
        }

        public async Task<Job> UpdateJob(Job entity)
        {
            try
            {
                _dbContext.ApplyChanges(entity);
                await _dbContext.SaveChangesAsync();
                entity.AcceptChanges();
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
            entity.AcceptChanges();
            return entity;
        }

        public async Task<bool> DeleteJob(int id)
        {
            Job entity = await _dbContext.Jobs
                .SingleOrDefaultAsync(x => x.jobId == id);
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

        public async Task<IEnumerable<Region>> GetRegionList()
        {
            IEnumerable<Region> entities = await _dbContext.Regions
                .OrderBy(r => r.regionName)
                .ToListAsync();
            return entities;
        }

        public async Task<string> GetRegionName(int? id)
        {
            Region region = await _dbContext.Regions
                .SingleOrDefaultAsync(x => x.regionId == id);

            return region.regionName;
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