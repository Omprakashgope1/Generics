using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Generics
{
    internal class DeleteArray
    {   
        public void DeleteMethod(int[] arr1,int element)
        {   
            List<int> list = new List<int>();
            int count = 0;
            foreach(int key in arr1)
            {
                if (element == key) list.Add(count);
                count++;
            }
            foreach(int key in list)
            {
                arr1[key] = 0;
            }
        }
        public void DeleteMethod(double[] arr1, double element)
        {
            List<int> list = new List<int>();
            int count = 0;
            foreach (double key in arr1)
            {
                if (element == key) list.Add(count);
                count++;
            }
            foreach (int key in list)
            {
                arr1[key] = 0.0;
            }
        }
        public void DeleteMethod(char[] arr1, char element)
        {
            List<int> list = new List<int>();
            int count = 0;
            foreach (char key in arr1)
            {
                if (element == key) list.Add(count);
                count++;
            }
            foreach (int key in list)
            {
                arr1[key] = '\0';
            }
        }
        public void DeleteMethodGen<T>(T[] arr,T element)
        {
            List<int> list = new List<int>();
            int count = 0;
            foreach(var key in arr)
            {
                if(key.Equals(element)) list.Add(count);
                count++;
            }
            foreach(int key in list)
            {
                arr[key] = default(T);
            }
        }
    }
}
