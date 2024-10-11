using Hepta.PraticalEvaluation.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hepta.PraticalEvaluation.Infrastructure.Data.Repositories
{
    public interface IRepository<TDataKeyType, TEntity>
        where TEntity : BaseEntity<TDataKeyType>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity FindById(TDataKeyType id);
        IList<TEntity> GetAll();
    }

}
