/*2.영문자를 입력받습니다
   소문자는 대문자로, 대문자는 소문자로 변경해서 출력하세요 (조건 연산자를 사용하세요)
   (아스키테이블/유니코드테이블을 참조하면 됩니다)*/
using System;

namespace _2020_07_24_HW_02
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
                if (b >= 65 && b <= 90)
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
                Console.WriteLine();
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

