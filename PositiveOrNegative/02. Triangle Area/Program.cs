﻿using System;
using System.Runtime.CompilerServices;

namespace Nums1To10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = a * h / 2;

            Console.WriteLine("{0:F2}", area);
        }
    }
}