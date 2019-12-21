using System;

namespace Практическая_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, i = 1, l = 0;
            int k;
            k = Convert.ToInt32(Console.ReadLine());
            while (l < k)
            {
                a = i * i;
                Console.Write(a);
                l += CountNumbers(a);
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("result = " + (a / power(l - k)) % 10);
            Console.ReadLine();
        }

        static int power(int k)
        {
            int result = 1;
            for (int i = 1; i <= k; i++)
                result *= 10;
            return result;
        }

        static int CountNumbers(int a)
        {
            int count = 0;
            while (a > 0)
            {
                count++;
                a /= 10;
            }
            return count;
        }
    }
}
