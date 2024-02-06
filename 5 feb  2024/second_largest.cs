using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class second_largest
    {
        static void Main(string[] args)
        {
            int[] a = { 2 };
            int[] q = a.Distinct().ToArray();
            if (a.Length < 2)
            {
                Console.WriteLine("There is no second largest element in the array.");
            }
            else
            {
                Console.WriteLine("Second Largest: " + findSecondLargest(q));
            }
          
        }
        public static int findSecondLargest(int[] q)
        {
            int temp;
           
            for (int i = 1; i < q.Length; i++)
            {
                for (int j = i + 1; j < q.Length; j++)
                {
                    if (q[i] < q[j])
                    {
                        temp = q[i];
                        q[i] = q[j];
                        q[j] = temp;
                        Console.WriteLine(q[j]);
                    }
                }
            }
            return q[1];
              
        }


    }
    
}
