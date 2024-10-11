using System;
using System.Collections.Generic;
using System.Linq;
using Hepta.PraticalEvaluation.Domain;

namespace Hepta.PraticalEvaluation.Infrastructure.Data.Repositories.Generic
{
    public class Repository<TDataKeyType, TEntity> : IRepository<TDataKeyType, TEntity>
        where TEntity : BaseEntity<TDataKeyType>
    {

        private List<TEntity> _list;

        public Repository()
        {
            _list = new List<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _list.Add(entity);
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            _list.Remove(entity);
        }

        public TEntity FindById(TDataKeyType id)
        {
            return _list.Find(x => x.Id.Equals(id));
        }

        public IList<TEntity> GetAll()
        {
            return _list.ToList();
        }

     
    }
}
