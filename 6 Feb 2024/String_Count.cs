//Problem Description No 2:Find all character count of given string 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class String_Count
    {
        static void Main(string[] args)
        {
            string str = "RUTUJA";
            Console.WriteLine("String: " + str);
            while (str.Length > 0)
            {
                Console.Write(str[0]+"-");
                int temp = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[0] == str[i])
                    {
                        temp++;
                    }
                }
                Console.WriteLine(temp);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }
    }
}
