using System;


namespace NumberOfPages
{
    class Program
    {
        static void Main()
        {

            int d = int.Parse(Console.ReadLine());
            int digitsOfNum = d.ToString().Length;
            int result = 0;
            
                if(digitsOfNum == 1 )
                {
                result = d;
                }
                else if(digitsOfNum == 2)
            {
                result = (d + 9) / 2;
            }
                else if(digitsOfNum == 3)
                {
                result = (d + 99 + 9) / 3;
                }
                else if(digitsOfNum==4){
                result = (d +999+ 99 + 9) / 4;
            }
                else if (digitsOfNum == 5)
            {
                result = (d + 9999+999 + 99 + 9) / 5;
            }
            else
            {
                result = (d + 99999 +9999 + 999 + 99 + 9) / 6;
            }

            Console.WriteLine(result);
        }
    }
}
