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
        Task<IEnumerable<User>> GetUsersList();

        [OperationContract(Name = "GetUser")]
        Task<User> GetUser(int? id);

        [OperationContract(Name = "GetUserLogin")]
        Task<User> GetUserLogin(string userName, string password);

        [OperationContract(Name = "UpdateUser")]
        Task<User> UpdateUser(User entity);

        [OperationContract(Name = "CreateUser")]
        Task<User> CreateUser(User entity);

        [OperationContract(Name = "DeleteUser")]
        Task<bool> DeleteUser(int id);
    }
}