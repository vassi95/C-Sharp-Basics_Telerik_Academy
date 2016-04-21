using System;


namespace NthBit
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong p = ulong.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());
            double pPow = (ulong)Math.Pow(2, 55);
            
            if ((n < 55) && (p <= pPow))
            {
                ulong result = (p >> n) & 1;
                Console.WriteLine(result == 0 ? "0" : "1");
            }
        }
    }
}
