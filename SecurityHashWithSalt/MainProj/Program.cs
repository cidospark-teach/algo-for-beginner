using System;

namespace MainProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var challenge = new ClassLib.Challenge();

            var exitCode = 0;
            while (exitCode < 1)
            {
                Console.WriteLine("Enter value to generate hash: ");
                var valToHash = Console.ReadLine();
                var hashResult = challenge.GenHash(valToHash);
                var salt = hashResult.Salt;
                var hash = hashResult.HashValue;

                Console.Write($"Salt: ");
                foreach (var item in salt)
                    Console.Write($"{item}");

                Console.WriteLine("\n");

                Console.WriteLine($"Hash: ");
                foreach (var item in hash)
                    Console.Write($"{item}");

                Console.WriteLine("\n");
                Console.WriteLine("\nEnter same value to compare with hash");
                var valToCompare = Console.ReadLine();
                Console.WriteLine(challenge.CompareHash(valToCompare, hash, salt));

                Console.WriteLine("\n");
                Console.WriteLine("Enter number greater than zero to exit loop");
                exitCode = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
            }

        }
    }
}
