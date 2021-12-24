using System;
using SolutionLib;

namespace MainProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6 };
            int searchTerm = 5;

            var res = !BinarySearchChallenge.Search<int>(arr, searchTerm) ?
                "Not found!" : $"Found! {searchTerm} at index {Array.IndexOf(arr, searchTerm)}";
             
            Console.WriteLine(res);
        }
    }
}
