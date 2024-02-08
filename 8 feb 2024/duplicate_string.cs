//Problem Description : Given a string s, consider all duplicated substrings: (contiguous)substrings of s that occur 2 or more times. The occurrences may overlap.Return any duplicated substring that has the longest possible length. If s does not have a duplicated substring, the answer is "".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class duplicate_string
    {
     
        public static string Substring(string s)
        {
            int n = s.Length;
            string result = "";

            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j <= n - i; j++)
                {
                    string substr = s.Substring(j, i);
                    if (s.IndexOf(substr, j + 1) != -1)
                        return substr;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Input: \"banana\"");
            Console.WriteLine($"Output: {Substring("banana")}");

            Console.WriteLine($"Input: \"abcd\"");
            Console.WriteLine($"Output: {Substring("abcd")}");
        }
    }


}






