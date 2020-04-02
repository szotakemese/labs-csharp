using System;

namespace task1
{
    class Program
    {
        //Обчислити площу та периметр прямокутника, довжини сторін якого задаються.
        static void Main(string[] args)
        {
            Console.WriteLine("a= ");
            double a = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("b= ");
            double b = Convert.ToDouble(Console.ReadLine());
            
            if( a>0 & b>0 ){

                double p = 2*a + 2*b;
                double s = a*b;
            
                Console.WriteLine("P={0} S={1}", p, s);
            }
            else Console.WriteLine("Incorrect numbers");


        }
    }
}
