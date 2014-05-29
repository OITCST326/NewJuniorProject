using AIM.Admin.Service.Contract.Models;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace AIM.Admin.Service.Contract
{
    [ServiceContract(Namespace = "urn:trackable-entities:service")]
    public interface IUserService
    {
        [OperationContract(Name = "GetUsersList")]
        Task<IEnumerable<User>> GetUsersListAsync();

        [OperationContract(Name = "GetUser")]
        Task<User> GetUserAsync(int? id);

        [OperationContract(Name = "GetUserLogin")]
        Task<User> GetUserLoginAsync(string userName, string password);

        [OperationContract(Name = "UpdateUser")]
        Task<User> UpdateUserAsync(User entity);

        [OperationContract(Name = "CreateUser")]
        Task<User> CreateUserAsync(User entity);

        [OperationContract(Name = "DeleteUser")]
        Task<bool> DeleteUserAsync(int id);
    }
}