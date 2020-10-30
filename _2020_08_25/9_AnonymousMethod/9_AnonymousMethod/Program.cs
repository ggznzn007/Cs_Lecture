using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9_AnonymousMethod
{
    delegate int dele(int a, int b);

    class Program
    {
        static int Calc(int a, int b, dele d)
        {
            return d(a, b);
        }
        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}
        static void Main(string[] args)
        {
            //dele add = delegate (int a, int b)
            //{
            //    return a + b;
            //};

            //int k = add(2, 3);
            //int k = Add(2, 3);

            int k = Calc(10, 20,
                delegate (int a, int b) { return a + b; });
            Console.WriteLine(k);
            k = Calc(10, 20,
                delegate (int a, int b) { return a - b; });
            Console.WriteLine(k);
            k = Calc(10, 20,
                delegate (int a, int b) { return a * b; });
            Console.WriteLine(k);
            k = Calc(10, 20,
                delegate (int a, int b) { return a / b; });
            Console.WriteLine(k);
        }
    }
}
