//Problem Description : Given an array of integers A, every element appears twice except for one. Find that integer that occurs once.NOTE: Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class bitwise
    {
        static void Main(string[] args)
        {
            int [] a = { 1, 2,2,3,1};
            int b = a[0];
            for(int i = 1;i<a.Length;i++)
            {          
                 b = b ^ a[i];
            }
            Console.WriteLine(b);
        }
    }
}
