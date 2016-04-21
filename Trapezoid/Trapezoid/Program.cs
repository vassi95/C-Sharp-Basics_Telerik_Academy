using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = ((a + b)* height)/2;

            Console.WriteLine(area.ToString("0.0000000"));

        }
    }
}
