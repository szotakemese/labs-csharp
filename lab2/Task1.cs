using System;

namespace task1
{
    class GeometricProg { 
       
        public double a; //first item
        public double q; //quotient
 
        public GeometricProg ()
        {         
            this.a = 1;         
            this.q = 1;     
        } 

        public string Get_a1 ()
        {
            Console.WriteLine("First item: ");
            this.a = Convert.ToDouble(Console.ReadLine());
            return "a1 = " + a;
        }

        public string Get_q ()
        {
            Console.WriteLine("Quotient: ");
            this.q = Convert.ToDouble(Console.ReadLine());
            return "q = " + q;
        } 

        public double Get_n_member (int n)     
        {   
            if (n >= 1)  return this.a * Math.Pow( this.q, n-1 );

            else return 0;
        } 

        public double Get_sum_n (int n)     
        {   
            if(n >= 1){
                if (n == 1) return a;

                else if (this.q == 1) return a * n;

                else return (a * (Math.Pow(q, n)-1)/(q-1));
            }
            else return 0;
            
        } 
    } 
 
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("n =");
            int n = Convert.ToInt32(Console.ReadLine());

            GeometricProg gp1 = new GeometricProg();
            Console.WriteLine(gp1.Get_a1());
            Console.WriteLine(gp1.Get_q());
            
            Console.WriteLine("N member: {0}", gp1.Get_n_member(n));
            Console.WriteLine("Sum of first N member: {0}", gp1.Get_sum_n(n));
        }
    }
}
