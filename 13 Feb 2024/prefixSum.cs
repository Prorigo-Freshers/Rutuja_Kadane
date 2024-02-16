using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class prefixSum
    {
        public static int[] PrefixSumArray(int[] A)
        {
            int[] prefixSum = new int[A.Length];
            prefixSum[0] = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + A[i];
            }
            return prefixSum;
        }

        public static int[] QuerySum(int[] prefixSum, int[][] queries)
        {
            int[] result = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int L = queries[i][0];
                int R = queries[i][1];
                if (L == 0)
                {
                    result[i] = prefixSum[R];
                }
                else
                {
                    result[i] = prefixSum[R] - prefixSum[L - 1];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 4, 5 };
            int[][] B = { new int[] { 0, 3 }, new int[] { 1, 2 } };

            int[] prefixSumA = PrefixSumArray(A);
            int[] output = QuerySum(prefixSumA, B);

            Console.WriteLine(string.Join(", ", output)); // Output: 10, 5
        }
    }
}
