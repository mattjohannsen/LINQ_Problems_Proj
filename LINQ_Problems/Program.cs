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
            Console.WriteLine("This is Problem One");
            //ProblemOne theProblemOne = new ProblemOne();
            //theProblemOne.PrintList(theProblemOne.words);
            //foreach (var item in theProblemOne.words)
            //{
            //    theProblemOne.CheckForTH(item);
            //    Console.WriteLine(item);
            //}
            //theProblemOne.CheckForTH();
            ProblemOne problemOne = new ProblemOne();
            string stringToCheck = "th";
            var wordlist = problemOne.words;
            var wordsWithTH = wordlist.Where(m => m.Contains(stringToCheck));
            //List<ProblemOne> words = problemOne.GetList();
            //List<ProblemOne> wordsWithoutTh = words.Contains(m => m.CheckForTH = false);
            foreach (var item in wordsWithTH)
            {
                Console.Write($"{item} ");
            }



            //MovieLibrary movieLibrary = new MovieLibrary();
            //List<Movie> movies = movieLibrary.GetMovies();
            ////List<Movie> hourAndAHalfMovieRunTime = movies.FindAll(m => m.runTime > 90);
            //foreach (var movie in hourAndAHalfMovieRunTime)
            //{
            //    Console.WriteLine(movie.title);
            //}

            //var ninetyMinuteMovies = movies.Where(m => m.runTime >= 90);
            //var ninentyMinuteMoviesSorted = ninetyMinuteMovies.OrderBy(m => m.title);


            Console.ReadLine();
        }
    }
}
