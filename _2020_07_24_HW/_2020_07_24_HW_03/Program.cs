/*3. 돈의 액수를 입금하세요
입금한 돈을 오만원권, 만원권, 오천원권, 천원권, 500원동전, 100원동전, 50원동전, 10원동전, 1원동전
각 몇개로 변환되는지 출력하세요
출력 개수는 단위가 큰 것 순서로 계산합니다
예를 들어 78670원이면<오만원 1매, 만원 2매, 오천원 1매, 천원 3매, 500원 1개, 100원 1개,
50원 1개, 10원 2개> 입니다.*/

using System;


namespace _2020_07_24_HW_03
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {                
                Console.WriteLine("입금할 금액을 입력해주세요 >> ");
                int Income = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int Omanwon = Income / 50000;
                int Manwon = (Income % 50000) / 10000;
                int Ocheonwon = ((Income % 50000) % 10000) / 5000;
                int Cheonwon = (((Income % 50000) % 10000) % 5000) / 1000;
                int Obackwon = ((((Income % 50000) % 10000) % 5000) % 1000) / 500;
                int Backwon = (((((Income % 50000) % 10000) % 5000) % 1000) % 500) / 100;
                int Oshipwon = ((((((Income % 50000) % 10000) % 5000) % 1000) % 500) % 100) / 50;
                int Shipwon = (((((((Income % 50000) % 10000) % 5000) % 1000) % 500) % 100) % 50) / 10;
                int Won = (((((((Income % 50000) % 10000) % 5000) % 1000) % 500) % 100) % 50) % 10;

                Console.WriteLine("오만원권 {0}매", Omanwon);
                Console.WriteLine();
                Console.WriteLine("  만원권 {0}매", Manwon);
                Console.WriteLine();
                Console.WriteLine("오천원권 {0}매", Ocheonwon);
                Console.WriteLine();
                Console.WriteLine("  천원권 {0}매", Cheonwon);
                Console.WriteLine();
                Console.WriteLine("  오백원 {0}개", Obackwon);
                Console.WriteLine();
                Console.WriteLine("    백원 {0}개", Backwon);
                Console.WriteLine();
                Console.WriteLine("  오십원 {0}개", Oshipwon);
                Console.WriteLine();
                Console.WriteLine("    십원 {0}개", Shipwon);
                Console.WriteLine();
                Console.WriteLine("    일원 {0}개", Won);
                Console.WriteLine();
                
            }

        }
    }
}
