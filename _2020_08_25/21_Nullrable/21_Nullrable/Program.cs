using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21_Nullrable
{
    class Program
    {
        static void Main(string[] args)
        {
            /* null은 클래스의 객체에 담는다
             * 객체 변수에 담으면
             * 아무것도 가리키지 않는다는 의미
             * 할당된 것이 없다
             * 그래서 null은 reference Type에 사용
             * 
             * But, int?처럼 Value Type에 사용하면
             * null값을 저장할 수 있다.
             * Value Type의 null은 "값이 정해지지 않았다"
             * 
             * C언어에서는 0==NULL로 개념을 혼재해서 사용
             * DB 0, null은 다르다
             * 홍길동 보너스가 0 : 0원
             * 홍길동 보너스가 null : 알수없다
             * 통계
             */
            int? Age;
            Age = null;
            if (Age.HasValue)
            {
                Console.WriteLine(Age);
            }
            else
            {
                Console.WriteLine("알 수 없는 나이임");
            }
        }
    }
}
