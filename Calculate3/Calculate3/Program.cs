﻿using System;
using System.Numerics;

class Calculate3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        if (k <= 1 || k > n || n <= 1 || n >= 100 || k >= 100)
        {
            return;
        }
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (i <= k)
            {
                factorialK *= i;
            }
        }
        for (int i = 1; i <= (n - k); i++)
        {
            factorialNK *= i;
        }
        Console.WriteLine("{0}", factorialN /
        (factorialK * (factorialNK)));
    }
}