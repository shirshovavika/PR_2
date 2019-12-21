using System;

namespace Практическая_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, proiz;
            Console.WriteLine("Введите x");
            x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите n");
            n = Convert.ToInt16(Console.ReadLine());
            proiz = 1;
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                proiz *= i;
                sum += (Math.Pow(x, i) / proiz);
            }
            Console.WriteLine("Oтвет: " + sum);
            Console.ReadLine();
        }
    }
}
