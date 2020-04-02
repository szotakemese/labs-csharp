using System;

namespace task2
{
    class TCircle
    {
        private double r_;
        private double[] center_;

        public double Get_r() { return r_; }
        public void Set_r(double r) 
        {
            if (r>0) r_= r; 
        }

        public double[] Get_center() { return center_; }
        public void Set_center(double[] center) 
        {
            if (center.Length ==2) center_= center; 
        }
        public TCircle (double r, double[] center)
        {
            Set_r(r);
            Set_center(center);
        }

        public string Output()
        {
            return "Radius: "+ this.r_ + "; Center: ( " + center_[0] + " , " + center_[1] + ")";
        }

        public double Area()
        {
            return Math.PI * Math.Pow(this.r_, 2);
        }

        public bool If_contains(double x, double y)
        {

            double lenght = Math.Sqrt(Math.Pow(x - this.center_[0], 2) + Math.Pow(y - this.center_[1], 2));
            return (lenght <= this.r_);
        }

        public static TCircle operator +(TCircle tc1, TCircle tc2)
        {
            return new TCircle(tc1.r_ + tc2.r_, tc1.center_);
        }

        public static TCircle operator -(TCircle tc1, TCircle tc2)
        {
            return new TCircle(Math.Abs(tc1.r_ - tc2.r_), tc1.center_);
        }
        public static TCircle operator *(TCircle tc,double k)
        {
            return new TCircle(tc.r_ * k, tc.center_);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("First circle");
            Console.WriteLine("Enter the radius: ");
            double radius1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the center coordinates: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double[] c1 ={x1,y1};
            double[] center_coordinates = new double[0];
            TCircle tc1 = new TCircle(1, center_coordinates);
            tc1.Set_r(radius1); 
            tc1.Set_center(c1); 

            Console.WriteLine(tc1.Output());
            Console.WriteLine("Area: "+tc1.Area());
            
            Console.WriteLine("Other point: ");
            double otherx = Convert.ToDouble(Console.ReadLine());
            double othery = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Circle contains the piont: "+ tc1.If_contains(otherx, othery));

            
            Console.WriteLine("Second circle");
            Console.WriteLine("Enter the radius: ");
            double radius2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the center coordinates: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double[] c2 ={x2,y2};
            TCircle tc2 = new TCircle(1, center_coordinates);
            tc2.Set_r(radius2); 
            tc2.Set_center(c2);


            Console.WriteLine("Summation radiuses: {0}", (tc1+tc2).Get_r());
            Console.WriteLine("Subtraction radiuses: {0}",(tc1-tc2).Get_r());

            Console.WriteLine("Enter the coefficient: ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Multipy radius: {0}",(tc1*k).Get_r());
        }
    }
}
