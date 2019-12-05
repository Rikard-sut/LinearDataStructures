
namespace Utility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Collections;
    public static class ConsoleUtility//Hjälpklass med hjälpmetod.
    {
        public static IEnumerable<T> ReadSequenceOfElements<T>() where T : IComparable 
        {
            var numbers = new List<T>();
            string input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                T number = (T)Convert.ChangeType(input, typeof(T));
                numbers.Add(number);

                input = Console.ReadLine();
            }
            return numbers;
        }
        public static void PrintListElements<T>(IList<T> list)
        {
            foreach(var element in list)
                Console.WriteLine(element);
        }
    }
}
