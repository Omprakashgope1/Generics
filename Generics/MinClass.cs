using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MinClass
    {
        public void findMinElement(int[] arr)
        {
            int smallest = Int32.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                smallest = Math.Min(smallest, arr[i]);
            }
            Console.WriteLine(smallest + " is the smallest value in the given array");
        }
        public void findMinElement(float[] arr)
        {
            float smallest = float.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                smallest = Math.Min(smallest, arr[i]);
            }
            Console.WriteLine(smallest + " is the smallest value in the given array");
        }
        public void findMinElement(string[] arr) 
        {
            string smallest = arr[0];
            for(int i = 1;i < arr.Length;i++)
            {
                if(smallest.CompareTo(arr[i]) > 0)
                {
                    smallest = arr[i];
                }
            }
            Console.WriteLine("smallest string in the given arr is : " + smallest);
        }
        public void findMinElementGen<T>(T[] arr) where T : IComparable<T> 
        {
            T smallest = arr[0];
            foreach(T key in arr)
            {
                if(key.CompareTo(smallest) < 0)
                {
                    smallest = key;
                }
            }
            Console.WriteLine("The smallest value in the array is : " + smallest);
        }
    }
}
