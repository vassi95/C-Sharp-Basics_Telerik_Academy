using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "integer":
                    int num = int.Parse(Console.ReadLine());
                    num += 1;
                    Console.WriteLine(num);
                    break;
                case "real":
                    double numb = double.Parse(Console.ReadLine());
                    numb += 1.00;
                    Console.WriteLine("{0:F2}", numb);
                    break;
                case "text":
                    string str = Console.ReadLine();
                    Console.WriteLine(str + "*");
                    break;
            }
        }
    }
}
