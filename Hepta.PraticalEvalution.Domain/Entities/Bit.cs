using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hepta.PraticalEvaluation.Domain
{
    public class Bit: IEnumerable<int>
    {
        private List<int> _list = new List<int>();
        public List<int> Items { get { return _list; } }
        public int this[int index]
        {
            get
            {
                return _list[index];
            }
        }
        public IEnumerator<int> GetEnumerator()
        {
            return _list.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }

}
