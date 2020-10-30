/*5. 정수 3개를 입력받고 이 3개의 수로 삼각형을 만들 수 있는지를 판별하세요
   삼각형이 가능하려면 두 변의 합이 다른 한 변의 합보다 반드시 커야 합니다. (조건 연산자를 사용하세요)*/
using System;

namespace _2020_07_24_HW_05
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please Input 3 Integars for make a Triangle >>");
                Console.WriteLine();
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(a + b > c + c ?
                    "It's Possible!!!" : "It's Impossible!!!");
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}
