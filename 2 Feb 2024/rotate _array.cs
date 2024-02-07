//Problem Description : Given an integer array A of size N and an integer B, you have to print the same array after rotating it B times towards the right.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4};

            Console.Write("Original Array Elements :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            int a = 2;
            a = a % arr.Length;
            ReverseArray(arr, 0, (arr.Length - 1));
            ReverseArray(arr, 0, a - 1);
            ReverseArray(arr, a, arr.Length - 1);
            Console.WriteLine("output");
            foreach(var op in arr)
            {
                Console.WriteLine(op + " ");
            }

            // Console.Write("\nReversed Array Elements :");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int  b = arr[0];

            //    arr[0] = arr[1];
            //    arr[1] = b;
            //    Console.Write(arr[i] + " ");
            //}

            //Console.ReadKey();
            
        }
        public static void ReverseArray(int[] arr,int i ,int j)
        {
            while (i < j)
            {
                int temp = arr[i];
                arr[i] = arr[j];

                arr[j] = temp;

                i++;
                j--;
            }
        }
    }
}
