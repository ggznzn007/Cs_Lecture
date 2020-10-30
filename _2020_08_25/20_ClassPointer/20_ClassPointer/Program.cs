using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20_ClassPointer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 3, 4, 5 };
            unsafe
            {
                fixed (int* pi = &ar[0])
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(pi[i]);
                    }
                }
            }
        }
    }
}
