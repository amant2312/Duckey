using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckey
{
    class DuckComparerBySize:IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            return x.Size-y.Size;
        }
    }
}
