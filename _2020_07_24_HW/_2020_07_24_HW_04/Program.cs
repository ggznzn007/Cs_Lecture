/*4. 369게임을 작성합니다.
   1~99까지의 정수를 입력받고
   3,6,9중 하나가 있으면 "박수짝"을 출력하고
   2개가 있으면 "박수짝짝"을 출력하세요
   예를 들어 13은 "박수짝"
   36인 경우는 "박수짝짝"을 출력하면 됩니다.*/
using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Threading;

namespace _2020_07_24_HW_04
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write(" 삼 육 구 게임을 시작하자 >> ");
                int num = Int32.Parse(Console.ReadLine());
                int f = num / 10; int b = num % 10;
                if (((f % 10 == 3) || (f % 10 == 6) || (f % 10 == 9)) &&
                    ((b % 10 == 3) || (b % 10 == 6) || (b % 10 == 9)))
                    Console.WriteLine("박수 짝짝");
                else if (((f % 10 == 3) || (f % 10 == 6) || (f % 10 == 9)) ||
                    ((b % 10 == 3) || (b % 10 == 6) || (b % 10 == 9)))
                    Console.WriteLine("박수 짝");
                else
                    Console.WriteLine("인디언~~~~~~밥!!!");
            }
        }
    }
}






















/*int t = num / 10; int o = num % 10; //t=num을 10으로 나눈 몫 o=num을 10으로 나눈 나머지
        if(((t%10==3)||(t%10==6)||(t%10==9))&&((o%10==3)||(o%10==6)||(o%10==9)))
        { // 10으로 나눴을 때 t와 o가 3이나 6이나 9가 동시에 나왔을 때 박수짝짝 출력
            System.out.println("박수짝짝");
        }
        else if(((t%10==3)||(t%10==6)||(t%10==9))||((o%10==3)||(o%10==6)||(o%10==9)))
        { // 10으로 나눴을 때 t와 o가 3이나 6이나 9가 둘중 하나만 나왔을 때 박수짝 출력
            System.out.println("박수짝");
        }
        else //이외의 경우 노우 박수~ 출력
            System.out.println("노우 박수~");*/


