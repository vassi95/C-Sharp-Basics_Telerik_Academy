using System;


namespace ExchangeIfGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1}", Math.Min(a, b), Math.Max(a, b));
        }
    }
}
