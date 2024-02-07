//Problem Description : Little Ponny is given an array, A, of N integers. In a particular operation, he can set any element of the array equal to -1.He wants your help in finding out the minimum number of operations required such that the maximum element of the resulting array is B. If it is not possible, then return -1.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        public static int maxOperations(int[] A, int B)
        {
            int temp = int.MinValue;
            int count = 0;
            bool valB = false;

            for (int i = 0; i < A.Length; i++)
            {
                int num = A[i];

                if (num > temp)
                    temp = num;

                if (num == B)
                    valB = true;

                if (num > B)
                    count++;
            }

            if (temp <= B)
                return 0;

            if (!valB)
                return -1;

            return count;

        }
        static void Main(string[] args)
        {
            int[] A1 = { 2, 4, 3, 1, 5 };
            int B1 = 3;
            Console.WriteLine(maxOperations(A1, B1));

            int[] A2 = { 1, 4, 2 };
            int B2 = 3;
            Console.WriteLine(maxOperations(A2, B2));

        }
    }
        
}

