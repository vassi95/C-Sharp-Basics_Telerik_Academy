using System;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now; 

            Console.Write("Please enter your birth date MM.DD.YYYY ");
            DateTime date  = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", null);
            int age = (today.Year - date.Year);
            if (today.Month < date.Month)
            {
                age--;
            }
            Console.WriteLine("Your age now: " + age); 
            Console.WriteLine("Your age after 10 years: " + (age + 10));
          
        }
    }
}
