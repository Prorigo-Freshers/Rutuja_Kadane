using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class add
    {
        static void Main(string[] args)
        {
            //int[] n = { 1, 2, 3, 4, -10 };
            int [] p = { -2, 1, -3, 4, -1, 2, 1, -5, 4};
            
            int sum = 0;
            int max = 0;
            for(int i=0; i<p.Length; i++)
            {
                sum += p[i];
                max = Math.Max(max, sum);
                if(sum <= 0)
                {
                    sum = 0;
                }
            }
            Console.WriteLine(max);
        }
    }
}
