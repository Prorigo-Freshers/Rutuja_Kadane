using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class CountSub
    {
        public static int CountSubstring(string A)
        {
            int MOD = 1000000007;
            int count_A = 0;
            int total_AG = 0;

            foreach (char c in A)
            {
                if (c == 'A')
                    count_A++;
                else if (c == 'G')
                    total_AG = (total_AG + count_A) % MOD;
            }

            return total_AG;
        }
        static void Main(string[] args)
        {
            string A1 = "ABCGAG";
            string A2 = "GAB";

            int result1 = CountSubstring(A1);
            int result2 = CountSubstring(A2);

            Console.WriteLine("Result 1: " + result1); // Output: 3
            Console.WriteLine("Result 2: " + result2); // Output: 0
        }
    }
}
