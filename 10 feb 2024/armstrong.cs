//Problem Description : You are given an integer N you need to print all the Armstrong Numbers between 1 to N. (N inclusive).If sum of cubes of each digit of the number is equal to the number itself, then the number is called an Armstrong number.For example, 153 = ( 1 * 1 * 1 ) + ( 5 * 5 * 5 ) + ( 3 * 3 * 3 ).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class armstrong
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N:");
            int N = int.Parse(Console.ReadLine().Trim());

            for (int num = 1; num <= N; num++)
            {
                int sum = 0;
                int temp = num;

                while (temp != 0)
                {
                    int digit = temp % 10;
                    sum += digit * digit * digit;
                    temp /= 10;
                }

                // Armstrong
                if (sum == num)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }

}
