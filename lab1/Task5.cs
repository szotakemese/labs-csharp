using System;

namespace task5
{
    class Program
    {
        /*Дано x, a є R; n є N. Знайти (((x+a)^2 +a)^2 +...+a)^2 +a
                                        n                           
        */
        static void Main(string[] args)
        {    
            Console.WriteLine("x =");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a =");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("n =");
            int n = Convert.ToInt32(Console.ReadLine());
            
            var ans = x + a;

            for( int i = 1; i < n; i++ ){
                ans = Math.Pow(ans, 2);
                ans += a; 
            }

            Console.WriteLine("Answer = {0}", ans);
        }
    }
}
