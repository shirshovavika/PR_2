using System;

namespace Практическая_7
{
    class Program
    {
        static Random rand = new Random();
        public static void Main()
        {
            Console.WriteLine("Введите длину массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            var array = new int[n, n];
            Console.WriteLine("Исходный массив:");
           for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write((array[i, j] = rand.Next(1, 11)) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Изменённый массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int secondArray = array[i, i];
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write((array[i, j] += secondArray) + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}
