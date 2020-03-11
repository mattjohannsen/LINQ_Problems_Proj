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
            //double returnedAverage = 0;
            //foreach (var item in problemThree.classGrades)
            //{
            //    var average = problemThree.classGrades.Select(g => g.Split(',').Select(int.Parse).ToList().OrderByDescending(i => i).Take(problemThree.classGrades.Count).Average()).Average();
            //    returnedAverage = Convert.ToDouble(average);
            //}
            //Console.WriteLine($"{returnedAverage}");
            //End of Problem Three

            //Start of Problem Four
            Console.WriteLine("This is Problem Four");
            ProblemFour problemFour = new ProblemFour();
            //var stringListOrdered = problemFour.inputString.OrderBy(x => x).ToArray().Count();
            //var stringListOrdered = problemFour.inputString.OrderBy(x => x).ToArray().Count();
            //Console.WriteLine($"{stringListOrdered}");
            //List<string> theList = new List<string>();
            var returnList = new List<string>();
            var theList = problemFour.inputString.ToUpper().OrderBy(a => a).ToList();
            var stringLetterFrequency = from a in theList group a by a into b select b;
            foreach (var letterToCount in stringLetterFrequency)
            {
                returnList.Add(letterToCount.Key.ToString());
                returnList.Add(letterToCount.Count().ToString());
                //Console.Write($"{letterToCount.Key}{letterToCount.Count()}");
            }
            foreach (var item in returnList)
            {
                Console.Write($"{item}");
            }

            //var stringToList = problemFour.inputString.ToUpper().OrderBy(a => a).ToArray();
            //var stringLetterFrequency = from a in stringToList group a by a into b select b;
            //Console.Write("The frequency of the characters are :\n");
            //var returnString = "";
            //foreach (var letterToCount in stringLetterFrequency)
            //{
            //    Console.Write($"{letterToCount.Key}{letterToCount.Count()}");
            //}
            //var count = stringToList.Count(f => f ==(stringToList.Distinct()));
            //var count = stringToList.TakeWhile(c => c == (stringToList.Distinct()).Count());
            //var numbersForList = stringToList
            //foreach (var item in count)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //foreach (var item in stringListOrdered)
            //{
            //    Console.WriteLine($"{item}");
            //}
            //End of Problem Four
            Console.ReadLine();
        }
    }
}
