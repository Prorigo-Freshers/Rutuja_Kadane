using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 16, 17, 4, 3, 5, 2 };
            int max = nums[nums.Length - 1];
            //Console.WriteLine(max);

            for (int i = nums.Length - 2; i <= 0; i--)
            {
                if (max < nums[i])
                {
                    Console.WriteLine(max);
                    max = nums[i];
                }
            }
        }
    }
}
