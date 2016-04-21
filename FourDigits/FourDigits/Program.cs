using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int first = (number/1000) %10;
            int second= (number / 100) % 10; ;
            int third= (number / 10) % 10; ;
            int fourth= number% 10;
            Console.WriteLine("" +(first +second + third+ fourth));
            Console.WriteLine(""+fourth + "" + third+ "" +second+ "" +first);
            Console.WriteLine("" + fourth + "" + first+ "" +second + "" + third );
            Console.WriteLine("" + first + "" + third + "" + second + "" + fourth);
        }
    }
}
