using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;
namespace _02.Integer_Reversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = ConsoleUtility.ReadSequenceOfElements<int>();
            Stack<int> stackElements = new Stack<int>(integers); //stack fylls på baklänges.
            
            

            ConsoleUtility.PrintListElements(stackElements.ToList());
            Console.ReadKey();

            
        }
    }
}
