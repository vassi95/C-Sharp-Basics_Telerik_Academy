using System;

namespace MoonGravity
{
    class Program
    {
        static void Main(string[] args)
        {
            float weight = float.Parse(Console.ReadLine());
            if(weight>0 && weight < 1000)
            {
                weight = (weight * 17 )/ 100;
            }
            Console.WriteLine(weight.ToString("0.000"));
        }
    }
}
