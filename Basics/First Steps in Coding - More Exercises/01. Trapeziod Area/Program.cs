﻿using System;
using System.Runtime.CompilerServices;

namespace Nums1To10
{
    class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double formulla = (b1 + b2) * h / 2;
            Console.WriteLine("{0:F2}", formulla);
        }
    }
}