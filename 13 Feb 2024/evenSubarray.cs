using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class evenSubarray
    {
        public static string CanDivide(int[] A)
        {
            // Check if the first and last elements are even
            if (A[0] % 2 != 0 || A[A.Length - 1] % 2 != 0)
                return "NO";

            return "YES";
        }
        static void Main(string[] args)
        {
           
                int[] A1 = { 2, 4, 8, 6 };
                int[] A2 = { 2, 4, 8, 7, 6 };

                string result1 = CanDivide(A1);
                string result2 = CanDivide(A2);

                Console.WriteLine("Result 1: " + result1); // Output: "YES"
                Console.WriteLine("Result 2: " + result2); // Output: "NO"
            
        }
    }
}
