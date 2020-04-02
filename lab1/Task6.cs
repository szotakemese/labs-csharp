using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var eps = 0.0001;
            Console.WriteLine("x =");
            double x = Convert.ToDouble(Console.ReadLine());
           
            
            if( Math.Abs(x) <= 1){ 
                double ans = Math.PI/2;         
                double a0 = -x;
                double c0 = 1;
            
                for( int n = 0; Math.Abs(a0/c0) >= eps ;n++){
                    ans += a0/c0;
                    c0 += 2;
                    a0 *= -Math.Pow(x, 2);
                }

                Console.WriteLine("Answer = {0}", ans);
                Console.WriteLine("arcctg = {0}", Math.Atan(1/x));
            }
            else Console.WriteLine("Incorrect X");
        }
    }
}
