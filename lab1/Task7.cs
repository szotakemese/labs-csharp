using System;

namespace task7
{
    class Program
    {
        /*      max(x, z) + max(x+y, xy)
            u = ------------------------
                    max^2(x+y, xy)
        */

        static double Max(double a, double b)         
        {      
            double max = a;       
            if (b > max)
                max = b;            
            return max;         } 
        static void Main(string[] args)
        {
            Console.WriteLine("x =");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y =");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("z =");
            double z = Convert.ToDouble(Console.ReadLine());

            double xz = Max(x,z);
            double xy = Max(x+y, x*y);
            double u = (xz+xy)/ Math.Pow(xy,2);

            Console.WriteLine("u = {0}", u);
        }
    }
}
