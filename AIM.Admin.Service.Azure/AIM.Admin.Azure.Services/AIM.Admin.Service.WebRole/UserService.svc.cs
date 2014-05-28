using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Threading.Tasks;
using AIM.Admin.Service.Contract;
using AIM.Admin.Service.Contract.Models;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace AIM.Admin.Service.WebRole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        public Task<IEnumerable<User>> GetUsersList()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserLogin(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUser(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<User> CreateUser(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
