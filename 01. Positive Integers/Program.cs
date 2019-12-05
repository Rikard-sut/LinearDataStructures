using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace _01.Positive_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var integers =  ConsoleUtility.ReadSequenceOfElements<int>(); //Kallar på hjälpmetod i namespace Utility, klass consoleutility.
            var sum = integers.Where(x => x > 0).Sum();
            var average = integers.Where(x => x > 0).Average();
            Console.ReadKey();


        }
        public static void Print(int sum, int average)
        {
            Console.WriteLine("Summan: {0}", sum);
            Console.WriteLine("Average: {0}", average);
        }
    }
}
