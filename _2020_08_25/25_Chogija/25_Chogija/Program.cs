using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _25_Chogija
{
    class Human
    {
        // 자동 프로퍼티
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human Jang = new Human();
            Jang.Name = "장길산";
            Jang.Age = 32;
            Console.WriteLine("이름 : " +
                Jang.Name + ", 나이 : " +
                Jang.Age);
        }
    }
}
