using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*아래처럼 Add함수를 만드는 일이 번거롭게 느껴질때
 * (즉, 1번만 사용하고 끝낼 것 같을 때)
 * 함수를 만들기 보다 즉석에서 delegate를 사용해서
 * 익명 메서드를 만들어 사용하는 경우가 종종 있다.
 * 
 * 익명 메서드는 함수의 동작은 구현하되 함수 이름은
 * 컴파일러가 알아서 부여하게 된다.
 * 어차피 함수 호출은 delegate변수를 통해서 호출하게 되므로
 * 함수 이름을 몰라도 관계없다.
 
     */

namespace _9_AnonymousMethod
{
    delegate int dele(int a, int b);

    class Program
    {
        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}
        static void Main(string[] args)
        {
            dele d = delegate (int a, int b)
            { return a + b; };

            int k = d(2, 3);
            //int k = Add(2, 3);

            Console.WriteLine(k);
        }
    }
}
