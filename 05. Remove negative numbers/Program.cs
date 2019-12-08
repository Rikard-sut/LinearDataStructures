using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace _05.Remove_negative_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = ConsoleUtility.ReadSequenceOfElements<int>().ToList();
            var positveNums = RemoveNegativeNumbers(integers);
            ConsoleUtility.PrintListElements(positveNums);
            Console.ReadKey();


        }
        public static IList<T> RemoveNegativeNumbers<T>(IList<T> list) where T : IComparable
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException("Collection of elements cannot be null or empty to remove negative numbers.");
            }
            var positiveNums = new List<T>();

            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo((T)Convert.ChangeType(0, typeof(T))) > 0) //COnverterar T till vad man stoppar in i metoden. Jämför mot värdet 0.
                {
                    positiveNums.Add(list[i]);
                }
            }
            return positiveNums;

        }
    }
}
