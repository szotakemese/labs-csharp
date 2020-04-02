using System;

namespace task4
{
    class Program
    {
        // Знайти периметр трикутника.
        static void Main(string[] args)
        {
            Console.WriteLine("x1 =");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y1 =");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x2 =");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y2 =");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x3 =");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y3 =");
            double y3 = Convert.ToDouble(Console.ReadLine());

            double a = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
            double b = Math.Sqrt(Math.Pow((x3-x2), 2) + Math.Pow((y3-y2), 2));
            double c = Math.Sqrt(Math.Pow((x1-x3), 2) + Math.Pow((y1-y3), 2));

            Console.WriteLine("P = {0}", a+b+c);
        }
    }
}
