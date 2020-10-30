using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 배열처럼 클래스를 포인터로 사용하려면
 * CLR한테 메모리를 고정시켜달라고 해야 한다.
 */

namespace _20_ClassPointer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 3, 4, 5 };
            unsafe
            {
                fixed (int* pi = &ar[0])
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(pi[i]);
                    }
                }
            }
        }
    }
}
