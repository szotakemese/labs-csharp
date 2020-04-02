using System;

namespace task3
{
    class Program
    {
        /*
            |1, 2x^2 - x - 3 = 0,
        y = |2, 2x^2 - x - 3 > 0,
            |0, 2x^2 - x - 3 < 0.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("x =");
            int x = Convert.ToInt32(Console.ReadLine());
            double ans = 2*(Math.Pow(x, 2)) - x - 3;
            int y;
            if(ans == 0)
                y = 1; 
            else if(ans > 0)
                y = 2;
            else
                y = 0;
            Console.WriteLine("y= {0}", y);
        }
    }
}
