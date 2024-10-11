using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hepta.PraticalEvaluation.Domain;

namespace Hepta.PraticalEvaluation.Application.Interfaces
{
    public interface IService<TDataKeyType, TEntity>
        where TEntity : BaseEntity<TDataKeyType>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity FindById(TDataKeyType id);
        IList<TEntity> GetAll();
    }

}
