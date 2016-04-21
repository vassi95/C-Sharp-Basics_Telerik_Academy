using System;


namespace _3rdBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int mask = 1 << 3;
            int test = N & mask;
            int result = test >> 3;
            Console.WriteLine(result);
        }
    }
}
