using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MinClassGen<T> where T : IComparable 
    {
        public static void findMinimum(T[] arr) 
        {
            T smallest = arr[0];
            foreach(T key in arr)
            {
                if(key.CompareTo(smallest) < 0)
                {
                    smallest = key;
                }
            }
            Console.WriteLine("The smallest of all the values in the given array is : " + smallest);
        }
    }
}
