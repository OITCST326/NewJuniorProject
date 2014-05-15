using AIM.Client.Entities.Models;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace AIM.ConsoleClient
{
    [ServiceContract(Namespace = "urn:trackable-entities:service")]
    public interface IQuestionService
    {
        [OperationContract(Name = "GetQuestionsList")]
        Task<IEnumerable<Question>> GetQuestionsListAsync();

        [OperationContract(Name = "GetQuestion")]
        Task<Question> GetQuestionAsync(int id);

        [OperationContract(Name = "UpdateQuestion")]
        Task<Question> UpdateQuestionAsync(Question entity);

        [OperationContract(Name = "CreateQuestion")]
        Task<Question> CreateQuestionAsync(Question entity);

        [OperationContract(Name = "DeleteQuestion")]
        Task<bool> DeleteQuestionAsync(int id);

        [OperationContract(Name = "GetQuestionnairesList")]
        Task<IEnumerable<Questionnaire>> GetQuestionnairesListAsync();

        [OperationContract(Name = "GetQuestionnaire")]
        Task<Questionnaire> GetQuestionnaireAsync(int id);

        [OperationContract(Name = "UpdateQuestionnaire")]
        Task<Questionnaire> UpdateQuestionnaireAsync(Questionnaire entity);

        [OperationContract(Name = "CreateQuestionnaire")]
        Task<Questionnaire> CreateQuestionnaireAsync(Questionnaire entity);

        [OperationContract(Name = "DeleteQuestionnaire")]
        Task<bool> DeleteQuestionnaireAsync(int id);
    }
}