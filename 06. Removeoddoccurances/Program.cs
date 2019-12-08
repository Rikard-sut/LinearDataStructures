using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace _06.Removeoddoccurances
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = ConsoleUtility.ReadSequenceOfElements<int>().ToList();
            var extractedElements = FindElements(integers, isOddNumberOfTimes: false); //skickar med bool som bestämmer om vi ska spara even eller odd numbers.
            PrintResult(integers, extractedElements);
            Console.ReadKey();
        }
        public static ISet<T> FindElements<T>(IList<T> list, bool isOddNumberOfTimes)
        {
            var oddOccurrences = new HashSet<T>();
            var evenOccurrences = new HashSet<T>();

            foreach (var element in list)
            {
                if (oddOccurrences.Add(element)) //addar elementet om den inte redan finns i Setet == addar bara om det blir ojämnt antal.
                {
                    // We have seen item an odd number of times
                    evenOccurrences.Remove(element); //tar bort denna siffra i evenoccurances för den är ojämn i antal.
                }
                else
                {
                    // We have seen item an even number of times
                    oddOccurrences.Remove(element); // Nu fanns den i ett jämnt antal, ta då bort denna siffra ur odd.
                    evenOccurrences.Add(element); //och lägg till den i even.  Fortsätter för varje varv tills man får ut alla ojämna och jämna occurances.
                }
            }
            //                            True              False
            return isOddNumberOfTimes ? oddOccurrences : evenOccurrences; //Skickar med evenoccurences för vi vill ta bort odd occurances.
        }

        public static void PrintResult<T>(IList<T> elements, ISet<T> evenNumberOfTimes)
        {
            
            var originalOrderOfElements = elements.Where(e => evenNumberOfTimes.Contains(e)); //Här sparar vi alla siffror som finns i evenNUmberOfTimes.
            Console.WriteLine("Result (original order): " + string.Join(" ", originalOrderOfElements));
        }
    }
}
