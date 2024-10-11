using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hepta.PraticalEvaluation.Domain
{
    public class DiagnosticReport
    {
        private List<BinaryNumber> _numbers;
        public DiagnosticReport() 
        {
            _numbers = new List<BinaryNumber>();
        }
        public List<BinaryNumber> Numbers
        {
            get { return _numbers; } 
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}
