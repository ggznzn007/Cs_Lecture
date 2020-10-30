using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19_Pointer
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3, j;
            unsafe
            {
                int* pi;
                pi = &i;
                j = *pi;
            }
            Console.WriteLine("i={0}, j={1}", i, j);
        }
    }
}
