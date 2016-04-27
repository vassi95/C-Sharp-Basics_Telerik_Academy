using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main()
        {

            string[] nums = Console.ReadLine().Split(' ');
            int a = Math.Abs(int.Parse(nums[0]));
            int b = Math.Abs(int.Parse(nums[1]));

            if (a < b)
            {
                int temp = b;
                b = a;
                a = temp;
            }
 
            int rest = 1;

            while (rest != 0)
            {
                rest = a % b;
                a = b;
                b = rest;
            }
            Console.WriteLine(a);
        }
    }
}
