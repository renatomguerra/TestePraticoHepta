using Hepta.PraticalEvaluation.Application.DI.Configuration;
using Hepta.PraticalEvaluation.Application.Extensions;
using Hepta.PraticalEvaluation.Application.Interfaces;
using Hepta.PraticalEvaluation.Domain;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hepta.PraticalEvaluation.Batch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ioc ioc = new Ioc();
            IDiagnosticService service = ioc.Kernel.Get<IDiagnosticService>();
            IList<BinaryNumber> list = service.GetAll();

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("         RELATÓRIO DE DIAGNÓSTICOS DE RUIDOS      ");
            Console.WriteLine("--------------------------------------------------");

            foreach (var item in list)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();

            var result = service.CalcularConsumoEnergia(list);
            var taxaGama = service.CalcularTaxaGama(list).ToString().FromBinaryNumberToDecimal();
            var taxaEpsilon = service.CalcularTaxaEpsilon(list).ToString().FromBinaryNumberToDecimal();

            Console.WriteLine($"Taxa Gama ...........: {taxaGama} ");
            Console.WriteLine($"Taxa Epsillon .......: {taxaEpsilon}");
            Console.WriteLine($"Consumo de energia ..: {result}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer <TECLA> para ENCERRAR");

            Console.ReadLine();
        }
    }
}
