﻿using System;
using System.Runtime.InteropServices;

namespace _06._Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sum = 0;

            foreach(char c in input) 
            {
                switch (c)
                {
                    case 'a':
                        sum++;
                        break;
                    case 'e':
                        sum+= 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}