using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _32_lambda
{
    delegate int dele(int a);

    class Program
    {
        static void Main(string[] args)
        {
            dele add = delegate(int a)
                    { return a + 1; };
            int k = add(3);
            Console.WriteLine("k = " + k);
        }
    }
}
