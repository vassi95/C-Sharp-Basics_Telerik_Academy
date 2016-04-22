using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFromOneToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                for(int i=0; i < n; i++)
                {
                    Console.Write((i + 1) + " ");
                }
            }
        }
    }
}
