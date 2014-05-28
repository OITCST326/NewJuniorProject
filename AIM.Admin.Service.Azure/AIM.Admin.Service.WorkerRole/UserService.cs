using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using AIM.Admin.Service.Contract;
using AIM.Admin.Service.WorkerRole.Models;
using TrackableEntities.Common;
using TrackableEntities.EF6;

namespace AIM.Admin.Service.WorkerRole
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class UserService : IUserService, IDisposable
    {
        private readonly AIM_DBContext _dbContext;

        public UserService()
        {
            _dbContext = new AIM_DBContext();
        }

        //async Task<IEnumerable<Contract.Models.User>> IUserService.GetUsersList()
        //{
        //    IEnumerable<User> entities = await _dbContext.Users
        //        .OrderBy(u => u.FirstName)
        //        .ThenBy(u => u.LastName)
        //        .Include(u => u.Applicant)
        //        .Include(u => u.Employee)
        //        .Include(u => u.PersonalInfo)
        //        .ToListAsync();
        //    return entities;
        //}

        Task<Contract.Models.User> IUserService.GetUser(int? id)
        {
            throw new NotImplementedException();
        }

        Task<Contract.Models.User> IUserService.GetUserLogin(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public Task<Contract.Models.User> UpdateUser(Contract.Models.User entity)
        {
            throw new NotImplementedException();
        }

        public Task<Contract.Models.User> CreateUser(Contract.Models.User entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Contract.Models.User>> IUserService.GetUsersList()
        {
            throw new NotImplementedException();
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

        public async Task<User> GetUserLogin(string userName, string password)
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