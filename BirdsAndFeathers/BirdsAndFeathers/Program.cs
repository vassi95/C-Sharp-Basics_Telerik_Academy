using System;

namespace BirdsAndFeathers
{
    class Program
    {
        static void Main(string[] args)
        {

            double B = double.Parse(Console.ReadLine());
            double F = double.Parse(Console.ReadLine());
            double result= (F / B);
            if (F == 0 || B == 0)
            {
                result = result * 0;
                Console.WriteLine("{0:F4}", result);
            }
            if (B % 2 == 0)
            {
                result =result * 123123123123;
                Console.WriteLine("{0:F4}", result);
            }
            
            else
            {
                result = result/317;
                Console.WriteLine("{0:F4}", result);
            }


            
        }
    }
}
