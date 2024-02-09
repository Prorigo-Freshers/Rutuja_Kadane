using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class longest_substring
    {
        

        static int longestSubstr(string str)
        {
            int n = str.Length;

            // Result
            int res = 0;

            for (int i = 0; i < n; i++)
            {

                bool[] temp = new bool[256];

                for (int j = i; j < n; j++)
                {

                    if (temp[str[j]] == true)
                        break;
                    else
                    {
                        res = Math.Max(res, j - i + 1);
                        temp[str[j]] = true;
                    }
                }

               
                temp[str[i]] = false;
            }
            return res;
        }

        static void Main()
        {
            //string s = "abcabcbb";
            //Console.WriteLine("The input string is " + s);

            //string s = "bbbbb";
            //Console.WriteLine("The input string is " + s);

            string s = "pwwkew";
            Console.WriteLine("The input string is " + s);

            int len = longestSubstr(s);
            Console.WriteLine("The length of the longest "
                            + "non-repeating character "
                            + "substring is " + len);
        }
    }

}
