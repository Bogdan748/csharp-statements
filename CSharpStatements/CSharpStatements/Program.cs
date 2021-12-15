using System;

namespace CSharpStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            int i = randomizer.Next(0,100);

            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is even.");
            }
            else
            {
                Console.WriteLine($"{i} is odd.");

            }
        }
    }
}
