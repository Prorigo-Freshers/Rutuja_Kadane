//Program description: check even or odd but without using arithmatic operations

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class evenodd
    {
        static void Main(string[] args)
        {
            //int n = 2;
            int n = 3;
            if ((n & 1) == 0){
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            
        }
    }
}
