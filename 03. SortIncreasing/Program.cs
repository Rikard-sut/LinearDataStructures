using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace _03.SortIncreasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>(ConsoleUtility.ReadSequenceOfElements<int>());
            var sorted = integers.OrderBy(x => x);
            ConsoleUtility.PrintListElements(sorted.ToList());
            Console.ReadKey();

        }
    }
}
