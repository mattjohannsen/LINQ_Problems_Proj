using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start of Problem One
            //Console.WriteLine("This is Problem One");
            //ProblemOne problemOne = new ProblemOne();
            //var wordsWithTH = problemOne.words.Where(m => m.Contains("th"));
            //foreach (var item in wordsWithTH)
            //{
            //    Console.Write($"{item} ");
            //}
            //End of Problem One

            // Start of Problem Two
            Console.WriteLine("This is Problem Two");
            ProblemTwo problemTwo = new ProblemTwo();
            var noDuplicates = problemTwo.names.Distinct();
            foreach (var item in noDuplicates)
            {
                Console.Write($"{item} ");
            }
            // End of Problem Two


            Console.ReadLine();
        }
    }
}
