using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    public class ProblemOne
    {
        public List<string> words;

        public ProblemOne()
        {
            words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

        }
        //public GetList()
        //{
        //    words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

        //    return words;
        //}
        
        public bool CheckForTH(string input)
        {
            //bool a = list.Contains<int>(7);
            //// Use instance method.
            //bool b = list.Contains(7);

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            return false;
        }
        public void PrintList(List<string> inputList)
        {
            foreach (var input in inputList)
            {
                Console.Write($"{input} ");
            }
        }
        
    }
}
