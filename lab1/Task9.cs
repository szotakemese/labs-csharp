using System;

namespace task9
{
    //Нехай X0=0, X1=X2=9, Xi=Xi-1 + Xi-2 + Xi-3. Визначити Xn. 
    class Program
    {
       //cycle
        static int x(int n)
        {
            if (n<=0)
                return 0;
            else if (n<=2)
                return 9;
            else{
                int x0 = 0;
                int x1 = 9;
                int x2 = 9;
                int xn = 18;
                for(int i = 3; i< n+1; i++){
                    xn = x2 + x1 + x0;
                    x0 = x1;
                    x1 = x2;
                    x2 = xn;
                }
                return xn;
            }
        } 
        
        /*
        //recurs
        static int x(int i)
        {
            if (i<=0)
                return 0;
            else if (i<=2)
                return 9;
            else{
                return x(i-1) + x(i-2) + x(i-3);
            }
        }
        */
        static void Main(string[] args)
        {
            Console.WriteLine("n= ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Xn = {0}", x(n));
        }
    }
}
