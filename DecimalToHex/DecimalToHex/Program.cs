using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            long dec = long.Parse(Console.ReadLine());


            var sb = new StringBuilder();
            while (dec > 0)
            {
                var r = dec % 16;
                dec /= 16;
                sb.Insert(0, ((long)r).ToString("X"));
            }
            Console.WriteLine( sb.ToString());
        }

        
    }
}
