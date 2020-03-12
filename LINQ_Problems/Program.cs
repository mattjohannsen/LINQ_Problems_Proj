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
            Console.WriteLine();
            Console.WriteLine("This is Problem One:");
            ProblemOne problemOne = new ProblemOne();
            var wordsWithTH = problemOne.words.Where(m => m.Contains("th"));
            foreach (var item in wordsWithTH)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            //End of Problem One

            // Start of Problem Two
            Console.WriteLine();
            Console.WriteLine("This is Problem Two:");
            ProblemTwo problemTwo = new ProblemTwo();
            //var noDuplicates = problemTwo.names.Distinct();
            var noDuplicates = problemTwo.names.OrderBy(s => new string(s.ToCharArray())).Distinct();
            foreach (var item in noDuplicates)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            // End of Problem Two

            //Start of Problem Three
            Console.WriteLine();
            Console.WriteLine("This is Problem Three:");
            ProblemThree problemThree = new ProblemThree();
            double returnedAverage = 0;
            foreach (var item in problemThree.classGrades)
            {
                var average = problemThree.classGrades.Select(g => g.Split(',').Select(int.Parse).ToList().OrderByDescending(i => i).Take(problemThree.classGrades.Count).Average()).Average();
                returnedAverage = Convert.ToDouble(average);
            }
            Console.WriteLine($"{returnedAverage}");
            //End of Problem Three

            //Start of Problem Four
            Console.WriteLine();
            Console.WriteLine("This is Problem Four:");
            ProblemFour problemFour = new ProblemFour();
            Console.WriteLine($"Initial string: {problemFour.inputString}");
            var returnList = new List<string>();
            var theList = problemFour.inputString.ToUpper().OrderBy(c => c).ToList().Select(a => a).GroupBy(b => b);
            foreach (var letterToCount in theList)
            {
                returnList.Add(letterToCount.Key.ToString());
                returnList.Add(letterToCount.Count().ToString());
            }
            string combinedString = string.Join("", returnList.ToArray());
            Console.WriteLine($"Return string: {combinedString}");
            //End of Problem Four
            Console.ReadLine();
        }
    }
}
