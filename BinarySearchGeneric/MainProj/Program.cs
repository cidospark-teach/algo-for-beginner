using System;
using SolutionLib;

namespace MainProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6 };
            var res = BinarySearchChallenge.Search<int>(arr, 6) <= 0? "Not found!" : "Found!";
             
            Console.WriteLine(res);
        }
    }
}
