using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckey
{
    internal class DuckCompareByKind : IComparer<Duck>
    {
        public int Compare(Duck a,Duck b)
        {
            return a.Kind - b.Kind;
        }
    }
}
