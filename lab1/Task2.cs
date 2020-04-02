using System;

namespace task2
{
    class Program
    {
        //Дано три дійсних числа: a, b, c. Знайти min(a,b)+(min(b,c))^2
        static void Main(string[] args)
        {
            Console.WriteLine("a= ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b= ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c= ");
            double c = Convert.ToDouble(Console.ReadLine());

            double ans = Math.Min(a,b)+ Math.Pow(Math.Min(b,c),2);
            Console.WriteLine("Answer={0} ", ans);
        }
    }
}
