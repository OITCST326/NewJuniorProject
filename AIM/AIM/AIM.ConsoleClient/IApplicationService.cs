using AIM.Client.Entities.Models;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace AIM.ConsoleClient
{
    [ServiceContract(Namespace = "urn:trackable-entities:service")]
    public interface IApplicationService
    {
        [OperationContract(Name = "GetApplicantsList")]
        Task<IEnumerable<Applicant>> GetApplicantsAsync();

        [OperationContract(Name = "GetApplicant")]
        Task<Applicant> GetApplicantAsync(int id);

        [OperationContract(Name = "UpdateApplicant")]
        Task<Applicant> UpdateApplicantAsync(Applicant entity);

        [OperationContract(Name = "CreateApplicant")]
        Task<Applicant> CreateProductAsync(Applicant entity);

        [OperationContract(Name = "DeleteApplicant")]
        Task<bool> DeleteApplicantAsync(int id);
    }
}