using Hepta.PraticalEvaluation.Application.Extensions;
using Hepta.PraticalEvaluation.Application.Interfaces;
using Hepta.PraticalEvaluation.Domain;
using Hepta.PraticalEvaluation.Infrastructure.Data.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace Hepta.PraticalEvaluation.Application.Services
{
    public class DiagnosticService : Service<int, BinaryNumber>, IDiagnosticService
    {
        private IBinaryNumberRepository _binaryNumberRepository;
        public DiagnosticService(IBinaryNumberRepository repository) : base(repository)
        {
            _binaryNumberRepository = repository;
        }
        private List<Bit> ObterListaBits(IList<BinaryNumber> binaryNumbers)
        {
            var bits = new List<Bit>();
            var lenght = binaryNumbers.Select(x => x.Value.Length).Max();

            for (int j = 0; j < lenght; j++)
            {
                var b = new Bit();

                for (int i = 0; i < binaryNumbers.Count; i++)
                {
                    b.Items.Add(int.Parse(binaryNumbers[i].Value[j].ToString()));
                }
                bits.Add(b);
            }

            return bits;
        }
        public int CalcularTaxaGama(IList<BinaryNumber> binaryNumbers)
        {
            var table = new Dictionary<int,int>();
            var result = new StringBuilder();
            var bits = ObterListaBits(binaryNumbers);

            foreach(var objBit in bits)
            {
               var grupo = objBit.Items.GroupBy(x=> x.ToString());
               var max = 0;
               var num = "";

               foreach(var item in grupo)
               {
                    if (item.Count() > max)
                    {
                        max = item.Count();
                        num = item.Key;
                    }
               }

               result.Append(num);
            }

            return int.Parse(result.ToString());
        }
        public int CalcularTaxaEpsilon(IList<BinaryNumber> binaryNumbers)
        {
            var table = new Dictionary<int, int>();
            var result = new StringBuilder();
            var bits = ObterListaBits(binaryNumbers);

            foreach (var objBit in bits)
            {
                var grupo = objBit.Items.GroupBy(x => x.ToString());
                var min = 0;
                var num = "";

                foreach (var item in grupo)
                {
                    if(min == 0)
                    {
                        min = item.Count();
                        num = item.Key;
                    }
                    else
                    {
                        if (item.Count() < min)
                        {
                            min = item.Count();
                            num = item.Key;
                        }
                    }
                }

                result.Append(num);
            }

            return int.Parse(result.ToString());
        }

        public int CalcularConsumoEnergia(IList<BinaryNumber> binaryNumbers) 
        {
            var taxaGama = CalcularTaxaGama(binaryNumbers).ToString().FromBinaryNumberToDecimal();
            var taxaEpsilon = CalcularTaxaEpsilon(binaryNumbers).ToString().FromBinaryNumberToDecimal();
            return taxaGama * taxaEpsilon;
        }
    }
}
