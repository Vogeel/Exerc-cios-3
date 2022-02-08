using System;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("ímpar: " + i);
                }
            }
            Console.ReadKey();
        }
    }
}
