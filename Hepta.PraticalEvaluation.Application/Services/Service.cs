using Hepta.PraticalEvaluation.Application.Interfaces;
using Hepta.PraticalEvaluation.Domain;
using System.Collections.Generic;
using Hepta.PraticalEvaluation.Infrastructure.Data.Repositories;

namespace Hepta.PraticalEvaluation.Application.Services
{
    public class Service<TDataKeyType, TEntity> : IService<TDataKeyType, TEntity>
        where TEntity : BaseEntity<TDataKeyType>
    {

        private IRepository<TDataKeyType, TEntity> _repository;

        public Service(IRepository<TDataKeyType, TEntity> repository) 
        {
            _repository = repository;
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }

        public TEntity FindById(TDataKeyType id)
        {
            return _repository.FindById(id);
        }

        public IList<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

    }
}
