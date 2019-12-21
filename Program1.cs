using System;

namespace Практическая_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, x0, y0, r, d;
            Console.WriteLine("Введите x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x0");
            x0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y0");
            y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите r");
            r = Convert.ToDouble(Console.ReadLine());
            d = Math.Sqrt(Math.Abs((x - x0) * (x - x0)) + Math.Abs((y - y0) * (y - y0)));
            if (d < r) Console.WriteLine("Принадлежит");
            else Console.WriteLine("Не принадлежит");
            Console.ReadLine();
        }
    }
}
