using System;

namespace MainProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var challenge = new ClassLib.Challenge();

            var hashResult = challenge.GenHash("123");
            var salt = hashResult.Salt;
            var hash = hashResult.HashValue;

            Console.Write($"Salt: ");
            foreach (var item in salt)
                Console.Write($"{item}");

            Console.WriteLine("\n");

            Console.WriteLine($"Hash: ");
            foreach (var item in hash)
                Console.Write($"{item}");
        }
    }
}
