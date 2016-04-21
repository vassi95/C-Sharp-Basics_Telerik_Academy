using System;


namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if(num>-30 || num < 30)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("even " + num);
                }
                else
                {
                    Console.WriteLine("odd " + num);
                }

            }
        }
    }
}
