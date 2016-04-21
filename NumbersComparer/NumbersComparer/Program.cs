using System;


namespace NumbersComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float max = Math.Max(a, b);
            Console.WriteLine(max);

        }
    }
}
