using System;

namespace Практическая_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 99; i++)
            {
                if (Math.Pow(i / 10 + i % 10, 3) == Math.Pow(i, 2))
                {
                    Console.WriteLine(i);
                }
                else Console.WriteLine("Такого нет");
            }
            Console.ReadLine();
        }
    }
}
