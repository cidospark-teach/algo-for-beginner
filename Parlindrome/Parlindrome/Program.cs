using System;
using Helper;

namespace Parlindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parlindrome is a word or phrase that reads the same backward or forward

            Console.WriteLine("CONFIRM IF THE WORD A PARLINDROME!\n");
            Challenge.DetermineParlindrome("tattarrattat");
        }
    }
}
