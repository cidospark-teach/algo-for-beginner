using System;
using SolutionLib;

namespace MainProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6 };
<<<<<<< HEAD
            var res = BinarySearchChallenge.Search<int>(arr, 10) <= 0? "Not found!" : "Found!";
=======
            int searchTerm = 5;

            var res = !BinarySearchChallenge.Search<int>(arr, searchTerm) ?
                "Not found!" : $"Found! {searchTerm} at index {Array.IndexOf(arr, searchTerm)}";
>>>>>>> binary-search
             
            Console.WriteLine(res);
        }
    }
}
