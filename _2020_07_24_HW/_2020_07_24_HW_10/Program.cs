/*10.int 배열로 10개의 공간을 생성하라
  1 ~ 10까지의 임의의 수를 저장하고
  홀수만 골라서 출력하라*/
using System;

namespace _2020_07_24_HW_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)//배열에 랜덤으로 값 저장
            {
                arr[i] = r.Next(1, 10);
            }
            for (int i = 0; i < arr.Length; i++)//배열에 저장한 값을 조건에 맞게 출력
            {
                if (arr[i] % 2 != 0)
                    Console.WriteLine(" {0} ", arr[i]);
                
            }
            Console.WriteLine();
        }
    }
}
