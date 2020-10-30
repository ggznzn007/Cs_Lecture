using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _29_ExtendedMethod
{
    public class Integer
    {
        public int a;
        public Integer(int aa) { a = aa; }
        public int Add(int b) { return a + b; }
        public int Mul(int b) { return a * b; }
    }

    class Program
    {
        static int Sub(Integer I, int b)
        { return I.a - b; }
        static int Div(Integer I, int b)
        { return I.a / b; }
        static void Main(string[] args)
        {
            Integer Num = new Integer(10);
            Console.WriteLine("덧셈 : " + Num.Add(5));
            Console.WriteLine("곱셈 : " + Num.Mul(5));
            Console.WriteLine("뺄셈 : " + Sub(Num, 5));
            Console.WriteLine("나눗셈 : " + Div(Num, 5));
        }
    }
}
