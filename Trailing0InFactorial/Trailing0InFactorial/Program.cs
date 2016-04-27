using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trailing0InFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 5; i < n; i *= 5)
            {
                int a = n / i;
                if (a < 1) { break; }
                else
                {
                    sum += a;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
