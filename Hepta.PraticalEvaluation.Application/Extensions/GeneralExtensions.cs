using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hepta.PraticalEvaluation.Application.Extensions
{
    public static class GeneralExtensions
    {
        public static int FromBinaryNumberToDecimal(this string value)
        {
            var result = 0;
            var posicao = value.Length - 1;

            for (int i=0; i < value.Length; i++)
            {
                var digit = int.Parse(value[i].ToString());
                var power = int.Parse(Math.Pow(2, posicao).ToString());
                var total = digit * power;

                result += total;
                posicao--;
            }

            return result;
        }
        public static string FromDecimalToBinaryNumber(this int value)
        {
            var binaryNumbers = new StringBuilder();
            var division = value;
            var rest = 0;

            while(division > 0)
            {
                var result = (division / 2);

                rest = (division % 2);
                division = result;

                binaryNumbers.Append(rest.ToString());
            }

            return binaryNumbers.ToString();
        }

    }
}
