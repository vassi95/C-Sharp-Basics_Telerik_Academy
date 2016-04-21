using System;


namespace PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt(x * x + y * y);
            if ((x) * (x) + (y) * (y) <= 2 * 2)
            {
                Console.WriteLine("yes " +distance.ToString("0.00"));
            }
            else
            {
                Console.WriteLine("no " + distance.ToString("0.00"));
            }

        }
    }
}
