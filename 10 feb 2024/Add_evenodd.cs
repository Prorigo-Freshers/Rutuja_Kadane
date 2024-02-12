//Problem Description : You are given an array of integers A of size N. Return the difference between the maximum among all even numbers of A and the minimum among all odd numbers in A.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Add_evenodd
    {
        static int MaxEvenMinOddDifference(int[] A)
        {
            int maxEven = int.MinValue;
            int minOdd = int.MaxValue;

            foreach (int n in A)
            {
                if (n % 2 == 0 && n > maxEven)
                {
                    maxEven = n;
                }
                else if (n % 2 != 0 && n < minOdd)
                {
                    minOdd = n;
                }
            }

            return maxEven - minOdd;
        }

        static void Main(string[] args)
        {
            int[] A1 = { 0, 2, 9 };
            int[] A2 = { 5, 17, 100, 1 };

            Console.WriteLine(MaxEvenMinOddDifference(A1)); // Output: -7
            Console.WriteLine(MaxEvenMinOddDifference(A2)); // Output: 99
        }
    }
}
