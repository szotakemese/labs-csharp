using System;

namespace task8
{
    class Program
    {
        static bool point_in_triangle(double[] p0, double[] p1, double[] p2, double[] p){
            
            double Area = 0.5 * ( -p1[1]*p2[0] + p0[1]*(-p1[0] + p2[0]) + p0[0]*(p1[1] - p2[1]) + p1[0]*p2[1]);
            double s = 1/(2*Area)*(p0[1]*p2[0] - p0[0]*p2[1] + (p2[1] - p0[1])*p[0] + (p0[0] - p2[0])*p[1]);
            double t = 1/(2*Area)*(p0[0]*p1[1] - p0[1]*p1[0] + (p0[1] - p1[1])*p[0] + (p1[0] - p0[0])*p[1]);
            if(s + t <= 1){
                if(0 <= t && t <= 1){
                    if(0 <= s && s <= 1){
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            else return false;
        }
        static double[] input_coor(string message){
            Console.WriteLine(message);
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double[] c = new double[] {x,y};
            return c;
        }
        static void Main(string[] args)
        {
            double[] A1 = input_coor("Enter A1");
            double[] A2 = input_coor("Enter A2");
            double[] A3 = input_coor("Enter A3");
            double[] B1 = input_coor("Enter B1");
            double[] B2 = input_coor("Enter B2");
            double[] B3 = input_coor("Enter B3");

            if( point_in_triangle(A1, A2, A3, B1) ==true && point_in_triangle(A1, A2, A3, B2) ==true && point_in_triangle(A1, A2, A3, B3) ==true){
                Console.WriteLine("Trinagle B is in A");
            }
            else Console.WriteLine("Trinagle B is NOT in A");
            if( point_in_triangle(B1, B2, B3, A1) ==true && point_in_triangle(B1, B2, B3, A2) ==true && point_in_triangle(B1, B2, B3, A3) ==true){
                Console.WriteLine("Trinagle A is in B");
            }
            else Console.WriteLine("Trinagle A is NOT in B");

        }
    }
}
