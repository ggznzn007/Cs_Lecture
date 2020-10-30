using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* delegate는 어떤 종류의 메서드를 저장할 수 있는지 표현하는
 * 자료형
 * delegate는 객체변수는 해당 메서드를 내부에 다수 저장 할 수 있다
 * 
 * C언어의 함수포인터와 같은 기능을 가진다.
 */
namespace _23_delegate
{
    delegate void dele(string s);

    class Outer
    {
        public static void m3(string s)
        { Console.WriteLine(s); }
        public void m4(string s)
        { Console.WriteLine(s); }
    }

    class Program
    {
        public static void m1(string s)
        { Console.WriteLine(s); }
        public void m2(string s)
        { Console.WriteLine(s); }
        static void Main(string[] args)
        {
            dele d = m1;
            d("정적 메서드");
            Program pr = new Program();
            d = pr.m2;
            d("인스턴스 메서드");

            d = Outer.m3;
            d("외부 정적 메서드");
            Outer O = new Outer();
            d = O.m4;
            d("외부 인스턴스 메서드");
        }
    }
}
