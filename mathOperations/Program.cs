﻿using System;

namespace mathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            
            Console.WriteLine("Enter a value for a: ");
            a = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter a value for b: ");
            b = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine($"Multiplying {a} x {b} equals {MultiplyNumbers(a,b)}");
        }
        static int MultiplyNumbers(int a, int b)
        {
            return a * b;
        }
    }
}