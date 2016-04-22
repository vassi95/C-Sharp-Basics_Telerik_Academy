using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDivisableNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 3 != 0 && i % 7 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
