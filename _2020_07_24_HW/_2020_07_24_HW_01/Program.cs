/*1. 영문자를 입력받습니다
   소문자인지 대문자인지 판별하세요(조건 연산자를 사용하세요)*/
using System;

namespace _2020_07_24_HW_01
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("영문자를 1개 입력해주세요>> ");
                Console.WriteLine();
                string a = Console.ReadLine();
                char b = Convert.ToChar(a);
                Console.WriteLine();
                Console.WriteLine((b >= 65 && b <= 90)
                    ? (b, "대문자 입니다") : (b, "소문자 입니다"));
                Console.WriteLine();
            }


        }
    }
}




/*if (b >= 65 && b <= 90)
                {
                    string c = Convert.ToString(b);
Console.WriteLine();
                    Console.WriteLine(c.ToLower());
                }
                else if (b >= 97 && b <= 122)
                {
                    string c = Convert.ToString(b);
Console.WriteLine();
                    Console.WriteLine(c.ToUpper());
                }
                Console.WriteLine();*/
