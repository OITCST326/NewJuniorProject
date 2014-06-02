using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using AIM.Administration.Entities;

namespace AIM.Administrative.Service
{
    [ServiceContract]
    public interface IAdministrativeService
    {

        /********************************************************************************************************************************/
        /*                               Applicant Model Implementation calls for Administrative Service                                */
        /********************************************************************************************************************************/

        /// <summary>
        /// Applicant Model Implementation calls for Administrative Service
        /// </summary>
        /// <seealso cref="AIM.Administrative.Service.AdministrativeService"/>
        /// <seealso cref="..GetApplicantsList"/>
        /// <seealso cref="..GetApplicant"/>
        /// <seealso cref="..UpdateApplicant"/>
        /// <seealso cref="..CreateApplicant"/>
        /// <seealso cref="..DeleteApplicant"/>

        #region

        [OperationContract(Name = "GetApplicantsList")]
        Task<IEnumerable<Applicant>> GetApplicantsList();

        [OperationContract(Name = "GetApplicant")]
        Task<Applicant> GetApplicant(int id);

        [OperationContract(Name = "UpdateApplicant")]
        Task<Applicant> UpdateApplicant(Applicant entity);

        [OperationContract(Name = "CreateApplicant")]
        Task<Applicant> CreateApplicant(Applicant entity);

        [OperationContract(Name = "DeleteApplicant")]
        Task<bool> DeleteApplicant(int id);

        #endregion

        /********************************************************************************************************************************/
        /*                                   Job Model Implementation calls for Administrative Service                                  */
        /********************************************************************************************************************************/

        /// <summary>
        /// Job Model Implementation calls for Administrative Service
        /// </summary>
        /// <seealso cref="AIM.Administrative.Service.AdministrativeService"/>
        /// <seealso cref="..GetJobsList"/>
        /// <seealso cref="..GetJob"/>
        /// <seealso cref="..UpdateJob"/>
        /// <seealso cref="..CreateJob"/>
        /// <seealso cref="..DeleteJob"/>

        #region

        [OperationContract(Name = "GetJobsList")]
        Task<IEnumerable<Job>> GetJobsList();

        [OperationContract(Name = "GetJob")]
        Task<Job> GetJob(int? id);

        [OperationContract(Name = "UpdateJob")]
        Task<Job> UpdateJob(Job entity);

        [OperationContract(Name = "CreateJob")]
        Task<Job> CreateJob(Job entity);

        [OperationContract(Name = "DeleteJob")]
        Task<bool> DeleteJob(int id);

        #endregion

        /********************************************************************************************************************************/
        /*                                Open Job Model Implementation calls for Administrative Service                                */
        /********************************************************************************************************************************/

        /// <summary>
        /// Open Job Model Implementation calls for Administrative Service
        /// </summary>
        /// <seealso cref="AIM.Administrative.Service.AdministrativeService"/>
        /// <seealso cref="..GetOpenJobsList"/>
        /// <seealso cref="..GetOpenJobsForStore"/>

        #region

        [OperationContract(Name = "GetOpenJobs")]
        Task<IEnumerable<OpenJob>> GetOpenJobs();

        [OperationContract(Name = "GetOpenJobsForStore")]
        Task<IEnumerable<OpenJob>> GetOpenJobsForStore(int? storeId);

        #endregion

        /********************************************************************************************************************************/
        /*                             Personal Info Model Implementation calls for Administrative Service                              */
        /********************************************************************************************************************************/

        /// <summary>
        /// Personal Info Model Implementation calls for Administrative Service
        /// </summary>
        /// <seealso cref="AIM.Administrative.Service.AdministrativeService"/>
        /// <seealso cref="..GetPersonalInfoList"/>
        /// <seealso cref="..GetPersonalInfoJob"/>
        /// <seealso cref="..UpdatePersonalInfo"/>
        /// <seealso cref="..CreatePersonalInfo"/>
        /// <seealso cref="..DeletePersonalInfo"/>

        #region

        [OperationContract(Name = "GetPersonalInfoList")]
        Task<IEnumerable<PersonalInfo>> GetPersonalInfoList();

        [OperationContract(Name = "GetPersonalInfo")]
        Task<PersonalInfo> GetPersonalInfo(int? id);

        [OperationContract(Name = "UpdatePersonalInfo")]
        Task<PersonalInfo> UpdatePersonalInfo(PersonalInfo entity);

        [OperationContract(Name = "CreatePersonalInfo")]
        Task<PersonalInfo> CreatePersonalInfo(PersonalInfo entity);

        [OperationContract(Name = "DeletePersonalInfo")]
        Task<bool> DeletePersonalInfo(int id);

        #endregion

        /********************************************************************************************************************************/
        /*                                Question Model Implementation calls for Administrative Service                                */
        /********************************************************************************************************************************/

        /// <summary>
        /// Question Model Implementation calls for Administrative Service
        /// </summary>
        /// <seealso cref="AIM.Administrative.Service.AdministrativeService"/>
        /// <seealso cref="..GetQuestionsList"/>
        /// <seealso cref="..GetQuestion"/>
        /// <seealso cref="..UpdateQuestion"/>
        /// <seealso cref="..CreateQuestion"/>
        /// <seealso cref="..DeleteQuestion"/>

        #region

        [OperationContract(Name = "GetQuestionsList")]
        Task<IEnumerable<Question>> GetQuestionsList();

        [OperationContract(Name = "GetQuestion")]
        Task<Question> GetQuestion(int id);

        [OperationContract(Name = "UpdateQuestion")]
        Task<Question> UpdateQuestion(Question entity);

        [OperationContract(Name = "CreateQuestion")]
        Task<Question> CreateQuestion(Question entity);

        [OperationContract(Name = "DeleteQuestion")]
        Task<bool> DeleteQuestion(int id);

        #endregion

        /********************************************************************************************************************************/
        /*                             Questionnaire Model Implementation calls for Administrative Service                              */
        /********************************************************************************************************************************/

        /// <summary>
        /// Questionnaire Model Implementation calls for Administrative Service
        /// </summary>
        /// <seealso cref="AIM.Administrative.Service.AdministrativeService"/>
        /// <seealso cref="..GetQuestionnairesList"/>
        /// <seealso cref="..GetQuestionnaire"/>
        /// <seealso cref="..UpdateQuestionnaire"/>
        /// <seealso cref="..CreateQuestionnaire"/>
        /// <seealso cref="..DeleteQuestionnaire"/>

        #region

        [OperationContract(Name = "GetQuestionnairesList")]
        Task<IEnumerable<Questionnaire>> GetQuestionnairesList();

        [OperationContract(Name = "GetQuestionnaire")]
        Task<Questionnaire> GetQuestionnaire(int id);

        [OperationContract(Name = "UpdateQuestionnaire")]
        Task<Questionnaire> UpdateQuestionnaire(Questionnaire entity);

        [OperationContract(Name = "CreateQuestionnaire")]
        Task<Questionnaire> CreateQuestionnaire(Questionnaire entity);

        [OperationContract(Name = "DeleteQuestionnaire")]
        Task<bool> DeleteQuestionnaire(int id);

        #endregion

        /********************************************************************************************************************************/
        /*                                 Region Model Implementation calls for Administrative Service                                 */
        /********************************************************************************************************************************/

        /// <summary>
        /// Region Model Implementation calls for Administrative Service
        /// </summary>
        /// <seealso cref="AIM.Administrative.Service.AdministrativeService"/>
        /// <seealso cref="..GetRegionList"/>

        #region

        [OperationContract(Name = "GetRegionList")]
        Task<IEnumerable<Region>> GetRegionList();

        #endregion

        /********************************************************************************************************************************/
        /*                                  Store Model Implementation calls for Administrative Service                                 */
        /********************************************************************************************************************************/

        /// <summary>
        /// Store Model Implementation calls for Administrative Service
        /// </summary>
        /// <seealso cref="AIM.Administrative.Service.AdministrativeService"/>
        /// <seealso cref="..GetStoreList"/>

        #region

        [OperationContract(Name = "GetStoreList")]
        Task<IEnumerable<Store>> GetStoreList(int? regionId);

        #endregion

        /********************************************************************************************************************************/
        /*                                  User Model Implementation calls for Administrative Service                                  */
        /********************************************************************************************************************************/

        /// <summary>
        /// User Model Implementation calls for Administrative Service
        /// </summary>
        /// <seealso cref="AIM.Administrative.Service.AdministrativeService"/>
        /// <seealso cref="..GetUsersList"/>
        /// <seealso cref="..GetUser"/>
        /// <seealso cref="..GetUserLogin"/>
        /// <seealso cref="..UpdateUser"/>
        /// <seealso cref="..CreateUser"/>
        /// <seealso cref="..DeleteUser"/>

        #region

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

        #endregion
    }
}
