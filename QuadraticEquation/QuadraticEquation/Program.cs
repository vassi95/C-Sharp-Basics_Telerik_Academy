using System;


namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            double d = b * b - 4 * a * c;
            
            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("{0:F2}", Math.Min(x1, x2));
                Console.WriteLine("{0:F2}", Math.Max(x1, x2));
            }
            if (d == 0)
            {
                Console.Write("{0:0.00}",  (-b / (2 * a)));
                
            }
            if (d < 0)
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
