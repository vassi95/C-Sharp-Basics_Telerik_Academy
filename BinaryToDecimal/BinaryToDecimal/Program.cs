using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main()
        {
            
            string binaryStr = Console.ReadLine();
            byte[] binarics = new byte[binaryStr.Length];
            for (int i = 0; i < binaryStr.Length; i++)
            {
                binarics[i] = byte.Parse(Convert.ToString((binaryStr[i])));
            }
            Array.Reverse(binarics);

            long numDecimal = 0;
            long multiplier = 1;
            foreach (var digit in binarics)
            {
                numDecimal += (digit * multiplier);
                multiplier *= 2;
            }

            Console.WriteLine(
                numDecimal);
                 }
    }
}
