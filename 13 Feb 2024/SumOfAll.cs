using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class SumOfAll
    {
        public static long SumOfAll(int[] A)
        {
            long MOD = 1000000007;
            long totalSum = 0;
            int N = A.Length;

            for (int i = 0; i < N; i++)
            {
                long sum = 0;
                for (int j = i; j < N; j++)
                {
                    sum += A[j];
                    totalSum += sum;
                    totalSum %= MOD;
                }
            }

            return totalSum;
        }
        static void Main(string[] args)
        {
            int[] A1 = { 1, 2, 3 };
            int[] A2 = { 2, 1, 3 };

            long result1 = SumOfAll(A1);
            long result2 = SumOfAll(A2);

            Console.WriteLine("Result 1: " + result1); // Output: 20
            Console.WriteLine("Result 2: " + result2); // Output: 19
        }
    }
}
