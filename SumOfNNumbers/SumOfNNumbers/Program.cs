using System;

namespace SumOfNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int n = int.Parse(Console.ReadLine());
            double sum = 0;
                for (int i = 0; i < n; i++)
                {
                    float num = float.Parse(Console.ReadLine());
                sum += num;
                }

            Console.WriteLine(sum);
            }
        
    }
}
