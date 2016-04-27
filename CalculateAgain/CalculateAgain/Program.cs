﻿using System;
using System.Numerics;
class CalculateAgain
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
        }
        for (int i = 1; i <= k; i++)
        {
            factorialK *= i;
        }
        Console.WriteLine(factorialN / factorialK);
    }
}