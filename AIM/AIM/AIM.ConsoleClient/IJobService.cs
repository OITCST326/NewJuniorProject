using AIM.Client.Entities.Models;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace AIM.ConsoleClient
{
    [ServiceContract(Namespace = "urn:trackable-entities:service")]
    public interface IJobService
    {
        [OperationContract(Name = "GetJobsList")]
        Task<IEnumerable<Job>> GetJobsListAsync();

        [OperationContract(Name = "GetJob")]
        Task<Job> GetJobAsync(int id);

        [OperationContract(Name = "UpdateJob")]
        Task<Job> UpdateJobAsync(Job entity);

        [OperationContract(Name = "CreateJob")]
        Task<Job> CreateJobAsync(Job entity);

        [OperationContract(Name = "DeleteJob")]
        Task<bool> DeleteJobAsync(int id);

        [OperationContract(Name = "GetOpenJobs")]
        Task<IEnumerable<OpenJob>> GetOpenJobsAsync();

        [OperationContract(Name = "GetStoreList")]
        Task<IEnumerable<Store>> GetStoreListAsync(int? region);

        [OperationContract(Name = "GetRegionList")]
        Task<IEnumerable<Region>> GetRegionListAsync();

        [OperationContract(Name = "GetOpenJobsForStore")]
        Task<IEnumerable<OpenJob>> GetOpenJobsForStoreAsync(int? store);
    }
}