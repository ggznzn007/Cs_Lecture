/*9.int배열을 10개 생성해라 사용자로부터 10개의 값을 입력받고
  순서대로 출력하고 총합을 구하세요*/
using System;
using System.Collections;

namespace _2020_07_24_HW_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Queue queue = new Queue();
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("10개의 값을 입력해주세요 >> ");
                arr[i] = Int32.Parse(Console.ReadLine());
                queue.Enqueue(arr[i]);
                sum += arr[i];
            }
            Console.WriteLine();
            while (queue.Count > 0)
            {
                Console.WriteLine("순서대로 출력 {0}",queue.Dequeue());               
            }
            Console.WriteLine();
            Console.WriteLine("총 합은 {0} 입니다", sum);
        }
    }
}
