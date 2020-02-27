using System;
namespace Delete_TestDome1
{
    public class QuadraticEquation
    {
        public static Tuple<double, double> FindRoots(double a, double b, double c)
        {
            var bsqrt = Math.Sqrt(b*b - 4*a*c);
            var x1 = ( -1*b+ bsqrt) /(2*a);
            var x2 = (-1 * b - bsqrt) / (2 * a );

            return new Tuple<double, double>(x1,x2);
        }

        public static void Check(string[] args)
        {
            Tuple<double, double> roots = QuadraticEquation.FindRoots(2, 10, 8);
            Console.WriteLine("Roots: " + roots.Item1 + ", " + roots.Item2);
        }
    }
}
