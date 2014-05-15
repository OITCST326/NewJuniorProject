using AIM.Application.Client.Entities.Models;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace AIM.Application.ConsoleClient
{
    [ServiceContract(Namespace = "urn:trackable-entities:service")]
    public interface IJobService
    {
        [OperationContract(Name = "GetJobsList")]
        Task<IEnumerable<Job>> GetJobsListAsync();

        [OperationContract(Name = "GetOpenJobsList")]
        Task<IEnumerable<OpenJob>> GetOpenJobsListAsync(int? regionID);

        [OperationContract(Name = "GetOpenJob")]
        Task<OpenJob> GetOpenJobAsync(int? id);

        [OperationContract(Name = "GetJob")]
        Task<Job> GetJobAsync(int? id);

        [OperationContract(Name = "UpdateJob")]
        Task<Job> UpdateJobAsync(Job entity);

        [OperationContract(Name = "CreateJob")]
        Task<Job> CreateJobAsync(Job entity);

        [OperationContract(Name = "DeleteJob")]
        Task<bool> DeleteJobAsync(int id);

        [OperationContract(Name = "GetRegionList")]
        Task<IEnumerable<Region>> GetRegionListAsync();

        [OperationContract(Name = "GetRegionName")]
        Task<string> GetRegionNameAsync(int? id);
    }
}