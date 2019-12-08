using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace _07.Numberfinder_within_range_1_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = ConsoleUtility.ReadSequenceOfElements<int>().ToList();
            var occurances = FindNumberOfOccurances(integers);
            PrintResult(occurances);
            Console.ReadKey();
        }
        public static IDictionary<T, int> FindNumberOfOccurances<T>(IList<T> list)
        {
            var dict = new Dictionary<T, int>();

            foreach(T number in list)
            {
                int count = 1;
                if (dict.ContainsKey(number)) // om T finns i dict lägg till T +1 i value(counter) för denna Key(T).
                {
                    count = dict[number] + 1;
                   // dict[number] = count;
                }
               // if (!dict.ContainsKey(number))
               //    dict[number] = count;
                dict[number] = count; // Om T inte finns i Dict lägg till T i dict med value 1 för occurance. //Om T finns i dict. Sätt den till samma värde den fick ovanför.
            }
            return dict;
        }
        public static void PrintResult<T>(IDictionary<T, int> list)
        {
            foreach(var pair in list)
            {
                Console.WriteLine("{0} -> {1} times(s)", pair.Key, pair.Value);
            }
        }
    }
}
