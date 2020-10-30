/*8.int배열을 10개 생성해라.
 int배열에 3의 배수를 차례대로 저장해라.
 그리고 거꾸로 출력해라.*/
using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace _2020_07_24_HW_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();//스택 선언
            for (int i = 1; i <= 10; i++)
            { st.Push(i * 3); }//반복문으로 3의 배수 입력
            while (st.Count > 0)
            { Console.WriteLine(st.Pop()); }//반복문으로 3의 배수 출력
        }

    }
}





            /*int[] arr = new int[10] ;
                Stack stack = new Stack();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("10개의 값을 입력해주세요 >> ");
                arr[i] = Int32.Parse(Console.ReadLine());
                stack.Push(arr[i]);
            }
            Console.WriteLine();
            while (stack.Count > 0)//stack에 있는 요소 전부를 가져온다
            { Console.Write("{0} ", stack.Pop()); }
            Console.WriteLine();*/


/*int[] arr = new int[] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };
Stack stack = new Stack(arr);
            for (int i = 0; i<arr.Length; i++)
            { Console.Write("{0} ", stack.Pop()); }
            Console.WriteLine();*/



/*for (int i = 0; i < arr.Length; i++)
            {
                stack.Push(arr[i]);
            stack.Push(arr[1]);
            stack.Push(arr[2]);
            stack.Push(arr[3]);
            stack.Push(arr[4]);
            stack.Push(arr[5]);
            stack.Push(arr[6]);
            stack.Push(arr[7]);
            stack.Push(arr[8]);
            stack.Push(arr[9]);
}
while (stack.Count > 0)//stack에 있는 요소 전부를 가져온다
            {
                Console.WriteLine("{0} ", stack.Pop());
            }
    }
    */





