using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace _04.LongestSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = new List<int>(ConsoleUtility.ReadSequenceOfElements<int>());
            var longest = FindLongestSequence(integers);
            PrintResult(integers, longest);
            Console.ReadKey();
            foreach(var number in longest)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();

        }
        public static IList<T> FindLongestSequence<T>(IList<T> list) where T : IComparable
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentException("Collection of elements cannot be null or empty to calculate longest sequence.");
            }
            T best = list[0]; //Sätter första elementet av T till första i collectionen. för att jämföra med.
            int count = 0; //Counter för att räkna occurance, startar på 0.
            T currentBest = list[0]; // declarerar current best för att göra jämförningar med.
            int currentCount = 0; // Counter för att räkna occurence av current.

            for (int i = 0; i < list.Count; i++)
            {
                if (currentBest.CompareTo(list[i]) == 0) 
                {
                    currentCount++;
                    if (currentCount >= count)
                    {
                        count = currentCount;
                        best = currentBest;
                    }

                }
                if (currentBest.CompareTo(list[i]) != 0)
                {
                    currentBest = list[i];
                    currentCount = 1;
                }
            }
            if(currentBest.CompareTo(best) != 0 && currentCount >= count)
            {
                best = currentBest;
                count = currentCount;
            }

            var longest = Enumerable.Repeat(best, count).ToList(); // Skapar lista av elementet som kom flest gånger och
            return longest;                                                       // sätter in så många de återkom av det.
        }
        public static void PrintResult<T>(IList<T> listOfSequence, IList<T> longest) where T : IComparable
        {
            Console.WriteLine(string.Join(" ", listOfSequence) + " -> " + string.Join(" ", longest));
        }
    }
}
