﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            Console.Write(findSum(n));

        }
        static int findSum(int n)
        {
            return n * (n + 1) / 2;
        }

    }
}