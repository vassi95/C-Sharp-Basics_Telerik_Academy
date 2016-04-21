using System;

namespace ThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number >= 0)
            {
                int digit = number / 100;
                digit = digit % 10;
                if(digit == 7)
                {
                    Console.WriteLine("true");

                }
                else
                {
                    Console.WriteLine("false " + digit);
                }
            }
        }
    }
}
