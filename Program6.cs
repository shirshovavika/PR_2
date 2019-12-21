using System;

namespace Практическая_6
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину строк:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину столбцов:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] originalArray = new int[n, m];
            double[] arrayOfSum = new double[n];
            double[] arrayOfMultipliers = new double[n];
            double[] meanValue = new double[n];
            double sum = 0, proiz = 1, srrr = 0;
            for (int i = 0; i < n; i++)
            {
                double minValue = 0, sumTwo = 0;
                for (int j = 0; j < m; j++)
                {
                    originalArray[i, j] = rand.Next(1, 10);
                    sum += originalArray[i, j];
                    sumTwo += originalArray[i, j];
                    proiz *= originalArray[i, j];
                    Console.Write(originalArray[i, j] + ", ");
                }
                Console.WriteLine();
                minValue = sumTwo / m;
                meanValue[i] = minValue;
                if (minValue >= srrr)
                {
                    srrr = Math.Round(minValue, 1);
                }
            }
            Console.WriteLine("Сумма и произведение элементов массива, а также наибольшее из средних арифметических его строк:");
            double[] end = new double[] { sum, proiz, srrr };
            for (int y = 0; y<end.Length; y++)
            {
                Console.Write(end[y] + ", ");
            }
            Console.ReadLine();
        }
    }
}
