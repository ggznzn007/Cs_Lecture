/*11. 정수 10개를 입력받아 배열에 저장하고,
이 정수중에서 2의 배수와 3의 배수를 출력하세요*/
using System;
using System.Collections;
using System.Security.Principal;

namespace _2020_07_24_HW_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("정수 10개를 입력해주세요 >> ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                { Console.WriteLine("2의 배수 {0} ", arr[i]); }
                else if (arr[i] % 3 == 0)
                { Console.WriteLine("3의 배수 {0} ", arr[i]); }
            }
            Console.WriteLine();
        }
    }
}
