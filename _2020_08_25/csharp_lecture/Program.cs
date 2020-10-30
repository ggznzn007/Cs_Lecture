using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9_AnonymousMethod
{
    delegate int dele(int a, int b);

    class Program
    {
        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}
        static void Main(string[] args)
        {
            dele d = delegate(int a, int b)
            { return a + b; }

            int k = d(2, 3);
            //int k = Add(2, 3);

            Console.WriteLine(k);
        }
    }
}
