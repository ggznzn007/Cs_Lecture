/*6. 연도를 입력받으세요 윤년인지 아닌지를 판별하세요
   4로 나누어 떨어지는 해는 일단 윤년에 포함시킵니다
   하지만 윤년중에 100으로 나누어떨어지는 해는 평년으로 하되
   평년중에 400으로 나누어 떨어지는 해는 윤년에 해당합니다*/
using System;

namespace _2020_07_24_HW_06
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("연도를 입력해주세요 >> ");
                int year = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                    //4의 배수, 100의 배수이면서 400의 배수라는 조건을 동시에 만족하는
                    Console.WriteLine("{0}년은 윤년이 맞습니다.", year);
                else
                    Console.WriteLine("{0}년은 윤년이 아닙니다.", year);
                Console.WriteLine();
            }
        }
    }
}
