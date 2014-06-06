using AIM.Application.Service.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ServiceModel;
using System.Threading.Tasks;
using TrackableEntities.Common;
using TrackableEntities.EF6;

namespace AIM.Application.Service.Core
{
    [ServiceContract(Namespace = "urn:trackable-entities:service")]
    public interface IPersonalInfoService
    {
        [OperationContract(Name = "GetPersonalInfoList")]
        Task<IEnumerable<PersonalInfo>> GetPersonalInfoList();

        [OperationContract(Name = "GetPersonalInfo")]
        Task<PersonalInfo> GetPersonalInfo(int id);

        [OperationContract(Name = "UpdatePersonalInfo")]
        Task<PersonalInfo> UpdatePersonalInfo(PersonalInfo entity);

        [OperationContract(Name = "CreatePersonalInfo")]
        Task<PersonalInfo> CreatePersonalInfo(PersonalInfo entity);

        [OperationContract(Name = "DeletePersonalInfo")]
        Task<bool> DeletePersonalInfo(int id);
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class PersonalInfoService : IPersonalInfoService, IDisposable
    {
        private readonly AIM_DBContext _dbContext;

        public PersonalInfoService()
        {
            _dbContext = new AIM_DBContext();
        }

        public async Task<IEnumerable<PersonalInfo>> GetPersonalInfoList()
        {
            IEnumerable<PersonalInfo> entities = await _dbContext.PersonalInfoes
                .ToListAsync();
            return entities;
        }

        public async Task<PersonalInfo> GetPersonalInfo(int id)
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

        public async Task<PersonalInfo> CreatePersonalInfo(PersonalInfo entity)
        {
            _dbContext.PersonalInfoes.Add(entity);
            await _dbContext.SaveChangesAsync();
            entity.AcceptChanges();

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