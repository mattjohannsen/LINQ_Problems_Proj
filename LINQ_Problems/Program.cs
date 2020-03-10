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
            //var noDuplicates = problemTwo.names.Distinct();
            var noDuplicates = problemTwo.names.OrderBy(s => new string(s.ToCharArray())).Distinct();
            foreach (var item in noDuplicates)
            {
                Console.Write($"{item} ");
            }
            // End of Problem Two

            //Start of Problem Three
            //Console.WriteLine("This is Problem Three");
            //ProblemThree problemThree = new ProblemThree();
            ////var turnStringToList = problemThree.classGrades.ToList();
            //foreach (var item in problemThree.classGrades)
            //{
            //    var temp = new List<int>(item.Split(',').Select(s => int.Parse(s)));
            //    foreach (var item2 in temp)
            //    {
            //        Console.WriteLine($"{item2}");
            //    }
            //    Console.WriteLine(".....");
            //    //var listWithLowestRemoved = new List<int>(temp.Remove(temp.Min());
            //    //foreach (var item3 in listWithLowestRemoved)
            //    //{
            //    //    Console.WriteLine($"{item}");
            //    //}

            //}
            //var turnStringToList = problemThree.classGrades.ToList();
            //turnStringToList.Select(int.Parse).ToList();
            //var turnListToInts = turnStringToList.Select(s => int.Parse(s));
            //var lowestValue = turnListToInts.Min();
            //var lowestRemoved = turnListToInts.Remove(turnListToInts.Min());
            //foreach (var item in turnStringToList)
            //{

            //    Console.Write($"{item}");

            //    //Console.Write($"{item} Lowest value: {lowestValue}");
            //}

            //End of Problem Three

            Console.ReadLine();
        }
    }
}
