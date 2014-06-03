using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using TrackableEntities.Patterns.EF6;
using AIM.Service.EF.Contexts;
using AIM.Service.Entities.Models;
using AIM.Service.Persistence.Repositories;

namespace AIM.Service.EF.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly IAIM_DBContext _context;

        public UserRepository(IAIM_DBContext context) :
            base(context as DbContext)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            IEnumerable<User> entities = await _context.Users.ToListAsync();
                //.OrderBy(u => u.FirstName)
                //.ThenBy(u => u.LastName)
                //.Include(u => u.Applicant.Users)
                //.Include(u => u.Employee)
                //.Include(u => u.PersonalInfo)
                
            return entities;
        }

        public async Task<User> GetUser(int id)
        {
            User entity = await _context.Users.SingleOrDefaultAsync(t => t.UserId == id);
                //.Include(u => u.Applicant)
                //.Where(u => id == u.Applicant.UserId)
                //.Include(u => u.Employee)
                //.Where(u => u.EmployeeId == u.Employee.EmployeeId)
                //.Include(u => u.PersonalInfo)
                //.Where(u => id == u.PersonalInfo.UserId)
                
            return entity;
        }

        public async Task<User> GetUserLogin(string userName, string password)
        {
            User entity = await _context.Users.Where(u => u.UserName.Equals(userName)).Where(u => u.UserName.Equals(password)).SingleOrDefaultAsync();
                
                //.Include(u => u.Applicant)
                //.Where(u => u.UserId == u.Applicant.UserId)
                //.Include(u => u.Employee)
                //.Where(u => u.EmployeeId == u.Employee.EmployeeId)
                //.Include(u => u.PersonalInfo)
                //.Where(u => u.UserId == u.PersonalInfo.UserId)
                
            return entity;
        }

        public async Task<bool> DeleteUser(int id)
        {
            User entity = await _context.Users.SingleOrDefaultAsync(t => t.UserId == id);
                //.Include(u => u.Applicant)
                //.Where(u => id == u.Applicant.UserId)
                //.Include(u => u.Employee)
                //.Where(u => u.EmployeeId == u.Employee.EmployeeId)
                //.Include(u => u.PersonalInfo)
                //.Where(u => id == u.PersonalInfo.UserId)
                
            if (entity == null) return false;
            ApplyDelete(entity);
            return true;
        }
    }
}
