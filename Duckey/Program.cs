using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckey
{
    internal class Program
    {
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach(Duck duck in ducks)
            {
                Console.WriteLine($"{duck.Size} inch {duck.Kind}"); ;
            }
        }
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck()
                {
                    Kind=KindOfDuck.Mallard, Size=17
                },
                new Duck()
                {
                    Kind=KindOfDuck.Muscovy, Size=18
                },
                new Duck()
                {
                    Kind=KindOfDuck.Loon, Size=14
                },
                new Duck()
                {
                    Kind=KindOfDuck.Muscovy, Size=11
                },
                new Duck()
                {
                    Kind=KindOfDuck.Mallard, Size=14
                },
                new Duck()
                {
                    Kind=KindOfDuck.Loon, Size=13
                },
            };
            PrintDucks(ducks);
            IComparer<Duck> duckCompareByKind = new DuckCompareByKind();  
            ducks.Sort(duckCompareByKind);
            Console.WriteLine();
            PrintDucks(ducks);
            Console.WriteLine();
            ducks.Sort();
            PrintDucks(ducks);
            Console.ReadLine();
        }
    }
}
