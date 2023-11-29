using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PrintClass
    {
        public static void printArray<T>(T[] arr)
        {
            foreach(var key in arr)
            {
                Console.Write(key + " ");
            }
            Console.WriteLine();
        }
    }
}
