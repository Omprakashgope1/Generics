using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class DeleteArrayGen<T>
    {
        public void DeleteElement(T[] arr,T key)
        {
            List<int> ls = new List<int>();
            int count = 0;
            foreach (var item in arr) 
            {
                if (item.Equals(item)) ls.Add(count);
                count++;
            }
            foreach(int item in ls) 
            {
                arr[item] = default(T);
            }
        }
    }
}
