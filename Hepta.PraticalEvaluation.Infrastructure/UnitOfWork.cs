using System;
using Hepta.PraticalEvaluation.Infrastructure.Data.Repositories.Interfaces;

namespace Hepta.PraticalEvaluation.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private IBinaryNumberRepository _binaryNumberRepository;

        public UnitOfWork(IBinaryNumberRepository binaryNumberRepository)
        {
            _binaryNumberRepository = binaryNumberRepository;
        }

        public IBinaryNumberRepository BinaryNumberRepository
        {
            get 
            { 
                return _binaryNumberRepository; 
            }
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }
    }
}
