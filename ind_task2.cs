using System;
namespace Math2
{
    class Program
    {
        static void Main(string[] args)
        {
            double w, x, a, b, y;

            Console.WriteLine("Введите x:");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите b:");
            b = double.Parse(Console.ReadLine());


            // 1 уравнение
            if ((x * x + b >= 0) && x != 0)
            {
                w = Math.Sqrt(Math.Pow(x, 2) + b) - Math.Pow(b, 2) * Math.Pow(Math.Sin(x + a), 3)/x;
                Console.WriteLine("Ответ первого уравнения:\nw = " + w);
            } 
            else Console.WriteLine("Введенные значения не входят в ОДЗ ((x^2 + b >= 0) и (x != 0)");

            // 2 уравнение
            if (a != 0 && b != 0)
            {
                y = Math.Pow(Math.Cos(Math.Pow(x, 3)), 2) - x/Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                Console.WriteLine("Ответ второго уравнения:\nw = " + y);
            }
            else Console.WriteLine("Введенные значения не входят в ОДЗ (a != 0 и b != 0)");

        }
    }
}
