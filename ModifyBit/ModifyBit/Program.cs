﻿using System;


namespace ModifyBit
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            uint p = uint.Parse(Console.ReadLine()); 
            uint v = uint.Parse(Console.ReadLine()); 

            ulong mask = (ulong)1 << (int)p;
            ulong bit = ((ulong)n & (ulong)mask) >> (int)p;

            if (bit != v)
            {
                n = (n ^ mask); 
            }
            Console.WriteLine(n);   


        }
    }
}
