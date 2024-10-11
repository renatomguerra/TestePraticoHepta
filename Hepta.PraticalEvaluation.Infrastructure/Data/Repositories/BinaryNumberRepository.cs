using Hepta.PraticalEvaluation.Domain;
using Hepta.PraticalEvaluation.Infrastructure.Data.Repositories.Generic;
using Hepta.PraticalEvaluation.Infrastructure.Data.Repositories.Interfaces;

namespace Hepta.PraticalEvaluation.Infrastructure.Data.Repositories
{
    public class BinaryNumberRepository: Repository<int, BinaryNumber>, IBinaryNumberRepository
    {
        public BinaryNumberRepository()
        {
            Add(new BinaryNumber { Id=1, Value="00100" });
            Add(new BinaryNumber { Id = 1, Value = "11110" });
            Add(new BinaryNumber { Id = 1, Value = "10110" });
            Add(new BinaryNumber { Id = 1, Value = "10111" });
            Add(new BinaryNumber { Id = 1, Value = "10101" });
            Add(new BinaryNumber { Id = 1, Value = "01111" });
            Add(new BinaryNumber { Id = 1, Value = "00111" });
            Add(new BinaryNumber { Id = 1, Value = "11100" });
            Add(new BinaryNumber { Id = 1, Value = "10000" });
            Add(new BinaryNumber { Id = 1, Value = "11001" });
            Add(new BinaryNumber { Id = 1, Value = "00010" });
            Add(new BinaryNumber { Id = 1, Value = "01010" });
        }
    }
}
