
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
                T number = (T)Convert.ChangeType(input, typeof(T)); // T är värdet av input och typen av T (Det man deklarerar den som när man kallar på metoden.
                numbers.Add(number);

                input = Console.ReadLine();
            }
            return numbers;
        }
        public static void PrintListElements<T>(IList<T> collection) //vill kunna skicka in en stack här tex genom att skriva ICollections<t> istället
        {                                                      //för IList<T>. Nu måste jag convertera Stack till List. ICollections funkade inte heller.
            foreach(var element in collection)
                Console.WriteLine(element);
        }
        
    }
}
