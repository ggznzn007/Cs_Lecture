/*7. 2차원 평면에서 하나의 직사각형은 두 점으로 표현된다.
   (50, 50)과(100, 100)의 두 점으로 이루어진 사각형이 있다고 하자.
  이 때 키보드로부터 한 점을 구성하는 정수 x와 y를 입력받고
   점(x, y)가 이 직사각형 안에 있는지 밖에 있는지 판별하는 프로그램을
   작성하세요*/
using System;

namespace _2020_07_24_HW_07
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("두 점 (x1,y1) (x2,y2)좌표를 정수로 입력해주세요 >> ");
                Console.WriteLine();
                int x1 = int.Parse(Console.ReadLine());
                int y1 = int.Parse(Console.ReadLine());
                int x2 = int.Parse(Console.ReadLine());
                int y2 = int.Parse(Console.ReadLine());
                if (((x1 >= 50 && x1 <= 100) && (y1 >= 50 && y1 <= 100))
                 || ((x2 >= 50 && x2 <= 100) && (y2 >= 50 && y2 <= 100)))
                {
                    Console.WriteLine("직사각형 안에 있습니다.");
                }
                else
                {
                    Console.WriteLine("직사각형 밖에 있습니다.");
                }
                Console.WriteLine();
            }
        }
    }
}
