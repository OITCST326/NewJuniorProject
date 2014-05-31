using AIM.Service.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using TrackableEntities;
using TrackableEntities.Common;
using TrackableEntities.EF6;

namespace AIM.Service.Administrative
{
    [ServiceContract(Namespace = "urn:trackable-entities:service")]
    public interface IQuestionService
    {
        [OperationContract]
        Task<IEnumerable<Question>> GetQuestionsList();

        [OperationContract]
        Task<Question> GetQuestion(int id);

        [OperationContract]
        Task<Question> UpdateQuestion(Question entity);

        [OperationContract]
        Task<Question> CreateQuestion(Question entity);

        [OperationContract]
        Task<bool> DeleteQuestion(int id);

        [OperationContract]
        Task<IEnumerable<Questionnaire>> GetQuestionnairesList();

        [OperationContract]
        Task<Questionnaire> GetQuestionnaire(int id);

        [OperationContract]
        Task<Questionnaire> UpdateQuestionnaire(Questionnaire entity);

        [OperationContract]
        Task<Questionnaire> CreateQuestionnaire(Questionnaire entity);

        [OperationContract]
        Task<bool> DeleteQuestionnaire(int id);
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class QuestionService : IQuestionService, IDisposable
    {
        private readonly AIM_DBContext _dbContext;

        public QuestionService()
        {
            _dbContext = new AIM_DBContext();
        }

        public async Task<IEnumerable<Question>> GetQuestionsList()
        {
            IEnumerable<Question> entities = await _dbContext.Questions
                .OrderBy(q => q.qJsonProperties)
                .ToListAsync();
            return entities;
        }

        public async Task<Question> GetQuestion(int id)
        {
            Question entity = await _dbContext.Questions
                .SingleOrDefaultAsync(x => x.questionId == id);
            return entity;
        }

        public async Task<Question> UpdateQuestion(Question entity)
        {
            _dbContext.ApplyChanges(entity);

            try
            {    
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return entity;
        }

        public async Task<Question> CreateQuestion(Question entity)
        {
            entity.TrackingState = TrackingState.Added;
            _dbContext.ApplyChanges(entity);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }

            await _dbContext.LoadRelatedEntitiesAsync(entity);
            entity.AcceptChanges();
            return entity;
        }

        public async Task<bool> DeleteQuestion(int id)
        {
            Question entity = await _dbContext.Questions
                .SingleOrDefaultAsync(x => x.questionId == id);
            if (entity == null)
                return false;

            entity.TrackingState = TrackingState.Deleted;
            _dbContext.ApplyChanges(entity);

            try
            {
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }
        }

        public void Dispose()
        {
            var dispose = _dbContext as IDisposable;
            if (dispose != null)
            {
                _dbContext.Dispose();
            }
        }

        public async Task<IEnumerable<Questionnaire>> GetQuestionnairesList()
        {
            IEnumerable<Questionnaire> entities = await _dbContext.Questionnaires
                .ToListAsync();
            return entities;
        }

        public async Task<Questionnaire> GetQuestionnaire(int id)
        {
            Questionnaire entity = await _dbContext.Questionnaires
                .SingleOrDefaultAsync(x => x.questionnaireId == id);
            return entity;
        }

        public async Task<Questionnaire> UpdateQuestionnaire(Questionnaire entity)
        {
            try
            {
                _dbContext.ApplyChanges(entity);
                await _dbContext.SaveChangesAsync();
                entity.AcceptChanges();
                return entity;
            }
            catch (DbUpdateConcurrencyException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }
        }

        public async Task<Questionnaire> CreateQuestionnaire(Questionnaire entity)
        {
            _dbContext.Questionnaires.Add(entity);
            await _dbContext.SaveChangesAsync();
            entity.AcceptChanges();
            return entity;
        }

        public async Task<bool> DeleteQuestionnaire(int id)
        {
            Questionnaire entity = await _dbContext.Questionnaires
                .SingleOrDefaultAsync(x => x.questionnaireId == id);
            if (entity == null)
                return false;

            try
            {
                _dbContext.Questionnaires.Attach(entity);
                _dbContext.Questionnaires.Remove(entity);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateConcurrencyException updateEx)
            {
                throw new FaultException(updateEx.Message);
            }
        }
    }
}