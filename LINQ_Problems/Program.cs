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
            //Console.WriteLine("This is Problem Two");
            //ProblemTwo problemTwo = new ProblemTwo();
            ////var noDuplicates = problemTwo.names.Distinct();
            //var noDuplicates = problemTwo.names.OrderBy(s => new string(s.ToCharArray())).Distinct();
            //foreach (var item in noDuplicates)
            //{
            //    Console.Write($"{item} ");
            //}
            // End of Problem Two

            //Start of Problem Three
            //Console.WriteLine("This is Problem Three");
            //ProblemThree problemThree = new ProblemThree();
            //foreach (var item in problemThree.classGrades)
            //{
            //    var average = problemThree.classGrades.Select(g => g.Split(',').Select(int.Parse).ToList().OrderByDescending(i => i).Take(problemThree.classGrades.Count).Average()).Average();
            //    Console.WriteLine($"{average}");
            //    Console.WriteLine(".....");
            //}
            //End of Problem Three

            //Start of Problem Four
            Console.WriteLine("This is Problem Four");
            ProblemFour problemFour = new ProblemFour();
            var stringToList = problemFour.inputString.ToList();
            foreach (var item in stringToList)
            {
                Console.WriteLine($"{item}");
            }
            var stringListOrdered = problemFour.inputString.OrderBy(x => x).ToList();
            foreach (var item in stringListOrdered)
            {
                Console.WriteLine($"{item}");
            }
            //End of Problem Four
            Console.ReadLine();
        }
    }
}
