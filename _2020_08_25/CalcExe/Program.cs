using System;
using System.ComponentModel;
using CalcLib;

namespace CalcExe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("첫 번째 숫자 입력 : ");
            double num0 = Double.Parse(Console.ReadLine());
            Console.Write("두 번째 숫자 입력 : ");
            double num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("+ 결과 " + Arith.add(num0, num1));
            Console.WriteLine("- 결과 " + Arith.sub(num0, num1));
            Console.WriteLine("* 결과 " + Arith.mul(num0, num1));
            Console.WriteLine("/ 결과 " + Arith.div(num0, num1));
        }
    }
}
