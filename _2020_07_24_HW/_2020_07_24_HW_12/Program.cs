/*12. 1부터 10까지 곱해서
그 결과를 출력하는 프로그램을 작성하세요*/
using System;

namespace _2020_07_24_HW_12
{
    class Program
    {
        static void Main(string[] args)
        {

            int GOAL_VALUE = 12;
            int value = Convert.ToInt32(GOAL_VALUE);
            int n = 1; 
            for (int i = 2; i <= value; i++)
                { n *= i; }
            Console.WriteLine(n);
        }
    }
}
