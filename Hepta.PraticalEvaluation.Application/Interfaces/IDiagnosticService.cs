using Hepta.PraticalEvaluation.Domain;
using System.Collections;
using System.Collections.Generic;

namespace Hepta.PraticalEvaluation.Application.Interfaces
{
    public interface IDiagnosticService: IService<int, BinaryNumber>
    {
        int CalcularTaxaGama(IList<BinaryNumber> binaryNumbers);
        int CalcularTaxaEpsilon(IList<BinaryNumber> binaryNumbers);
        int CalcularConsumoEnergia(IList<BinaryNumber> binaryNumbers);
    }
}
