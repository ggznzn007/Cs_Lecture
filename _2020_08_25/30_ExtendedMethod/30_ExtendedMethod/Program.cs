using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _30_ExtendedMethod
{
    public class Integer
    {
        public int a;
        public Integer(int aa)
                    { a = aa; }
        public int Add(int b)
                    { return a + b; }
        public int Mul(int b)
                    { return a * b; }
    }

    public static class IntegerExt
    {
        public static int Sub(this Integer I, int b)
        {
            return I.a - b;
        }
        public static int Div(this Integer I, int b)
        {
            return I.a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Integer Num = new Integer(10);
            Console.WriteLine("덧셈 : " + Num.Add(5));
            Console.WriteLine("곱셈 : " + Num.Mul(5));
            Console.WriteLine("뺄셈 : " + Num.Sub(5));
            Console.WriteLine("나눗셈 : " + Num.Div(5));
        }
    }
}
