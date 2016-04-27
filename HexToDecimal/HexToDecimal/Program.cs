using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDecimal
{
    class Program
    {
        static void Main(string[] args)

        {
            string hexNumber = Console.ReadLine();
            hexNumber = hexNumber.Replace("x", string.Empty);
            long result = 0;
            long.TryParse(hexNumber, System.Globalization.NumberStyles.HexNumber, null, out result);
            Console.WriteLine(result);
        }
    }
}
