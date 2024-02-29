using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckey
{
    class Duck:  IComparable<Duck>
    {
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }

        public int CompareTo(Duck duckToCompare)
        {
            return this.Size - duckToCompare.Size;
        }
    }
}
