using AIM.Admin.Service.WorkerRole.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using TrackableEntities.Common;
using TrackableEntities.EF6;

namespace AIM.Admin.Service.WorkerRole
{
    [ServiceContract(Namespace = "urn:trackable-entities:service")]
    public interface IUserService
    {
        [OperationContract]
        Task<IEnumerable<User>> GetUsersList();

        [OperationContract]
        Task<User> GetUser(int? id);

        [OperationContract]
        Task<User> UpdateUser(User entity);

        [OperationContract]
        Task<User> CreateUser(User entity);

        [OperationContract]
        Task<bool> DeleteUser(int id);
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class UserService : IUserService, IDisposable
    {
        private readonly AIM_DBContext _dbContext;

        public UserService()
        {
            _dbContext = new AIM_DBContext();
        }

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
                .Include(u => u.Applicant)
                .Include(u => u.Employee)
                .Include(u => u.PersonalInfo)
                .SingleOrDefaultAsync(x => x.UserId == id);
            return entity;
        }

        public async Task<User> GetUser(string userName, string password)
        {
            User entity = await _dbContext.Users
                .Include(u => u.Applicant)
                .Include(u => u.Employee)
                .Include(u => u.PersonalInfo)
                .SingleOrDefaultAsync(x => x.UserName == userName && x.Password == password);
            return entity;
        }

        public async Task<User> UpdateUser(User entity)
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

        public async Task<User> CreateUser(User entity)
        {
            _dbContext.Users.Add(entity);
            await _dbContext.SaveChangesAsync();
            entity.AcceptChanges();
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