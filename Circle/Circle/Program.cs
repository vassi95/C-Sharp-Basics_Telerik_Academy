using System;


namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            float radius = float.Parse(Console.ReadLine());
            Console.Write("{0:0.00}", Math.PI * radius * 2);

            Console.WriteLine(" {0:0.00}", Math.PI * radius * radius);

        }
    }
}
