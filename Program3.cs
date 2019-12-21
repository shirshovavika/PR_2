using System;

namespace Практическая_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1, s = 0, e;
            e = Convert.ToDouble(Console.ReadLine());
            int i = 0;
            while (a>=e)
            {
                i++;
                a = (1.0 / (i * (i + 2)));
                s += a;
            }
            Console.WriteLine("" + s);
            Console.ReadLine();
        }
    }
}
