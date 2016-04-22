using System;
using System.Linq;

namespace PlayCard
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            bool exists = cards.Contains(str);
            if (exists)
            {
                Console.WriteLine("yes " + str);
            }
            else
            {
                Console.WriteLine("no " + str);
            }
        }
    }
}
