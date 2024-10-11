using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hepta.PraticalEvaluation.Domain;
using Hepta.PraticalEvaluation.Infrastructure.Data.Repositories.Generic;

namespace Hepta.PraticalEvaluation.Infrastructure.Data.Repositories.Interfaces
{
    public interface IBinaryNumberRepository: IRepository<int, BinaryNumber>
    {
    }
}
