using System;


namespace PrintTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            


            for (byte i = 33; i < 127; i++)
            {
               Console.Write((char)i);
            }

        }
    }
}
