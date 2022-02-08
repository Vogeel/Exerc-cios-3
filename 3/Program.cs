using System;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 1; i <= 500; i++) 
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    total += i;

                    
                }
            }
            Console.WriteLine(total);
            Console.ReadKey();
        }

    }
}
