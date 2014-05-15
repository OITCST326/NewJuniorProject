using AIM.Client.Entities.Models;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace AIM.ConsoleClient
{
    [ServiceContract(Namespace = "urn:trackable-entities:service")]
    public interface IUserService
    {
        [OperationContract(Name = "GetUsersList")]
        Task<IEnumerable<User>> GetUsersListAsync();

        [OperationContract(Name = "GetUser")]
        Task<User> GetUserAsync(int? id);

        [OperationContract(Name = "UpdateUser")]
        Task<User> UpdateUserAsync(User entity);

        [OperationContract(Name = "CreateUser")]
        Task<User> CreateUserAsync(User entity);

        [OperationContract(Name = "DeleteUser")]
        Task<bool> DeleteUserAsync(int id);
    }
}